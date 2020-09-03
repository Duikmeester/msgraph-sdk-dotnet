Param(
    [string]$dllPath,
    [string]$outputPath
)

$twoSpaces = "  "
$fourSpaces = "    "

$assembly = [System.Reflection.Assembly]::LoadFrom($dllPath)
$types = $assembly.GetTypes() |
    Where-Object { $_.FullName.StartsWith("Microsoft.Graph") } |
    Sort-Object { $_.FullName }

function normalize([string]$str)
{
    # removes package version information for cleaner diffs
    # e.g. , Microsoft.Graph, Version=3.12.0.0, Culture=neutral, PublicKeyToken=null
    return $str -replace ", [\w\.]+, Version=\d+\.\d+\.\d+\.\d+, Culture=neutral, PublicKeyToken=(null|[a-f0-9]+)",""
}

$writer = [System.IO.File]::CreateText($outputPath)

try
{
    foreach ($type in $types | Where-Object { $_.IsEnum })
    {
        $writer.WriteLine("enum " + $type.FullName)

        foreach ($enumName in $type.GetEnumNames())
        {
            $writer.WriteLine($twoSpaces + $enumName)
        }
    }

    foreach ($type in $types |
        Where-Object { !$_.FullName.Contains("+") -and ($_.IsClass -or $_.IsInterface) } |
        Sort-Object { $_.IsInterface,$_.Name })
    {
        $declaration = "class "
        if ($type.IsInterface)
        {
            $declaration = "interface "
        }

        $declaration += $type.FullName
        if ($type.BaseType -and $type.BaseType.FullName -ne "System.Object")
        {
            $declaration += " : " + (normalize $type.BaseType.FullName)
        }

        $writer.WriteLine($declaration)

        # properties
        foreach ($property in $type.GetProperties() | Where-Object { $_.DeclaringType -eq $type } | Sort-Object { $_.Name })
        {
            $writer.WriteLine($twoSpaces + "property " + $property.Name + $getterSetter + " : " + (normalize $property.PropertyType.FullName))
        }

        # methods
        foreach ($method in $type.GetMethods() |
            Where-Object { $_.DeclaringType -eq $type -and !$_.Name.StartsWith("set_") -and !$_.Name.StartsWith("get_")} |
            Sort-Object { $_.Name,($_.GetParameters().Name -join " ") }) # get a deterministic order among methods
        {
            $writer.WriteLine($twoSpaces + "method " + $method.Name)
            $writer.WriteLine($fourSpaces + "return type " + (normalize $method.ReturnType.FullName))

            foreach($param in $method.GetParameters())
            {
                $writer.WriteLine($fourSpaces + "param " + $param.Name + " : " + (normalize $param.ParameterType.FullName))
            }
        }
    }
}
finally
{
    $writer.Close()
}