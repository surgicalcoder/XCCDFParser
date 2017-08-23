# XCCDFParser
XCCDF is a specification language for writing security checklists, benchmarks, and related kinds of documents. An XCCDF document represents a structured collection of security configuration rules for some set of target systems.

## Why this library?

The XCCDF is a bit of a rats nest of nested XML. The generated parsing code out of xsd2cs is less than optimal.

## How to use?

    var readAllText = File.ReadAllText(Path);
    
    XmlDocument document = new XmlDocument();

    document.LoadXml(readAllText);
    
    var json = JsonConvert.SerializeXmlNode(document);

    XCCDFParser.Container ee = JsonConvert.DeserializeObject<XCCDFParser.Container>(json);

## How to install?

[Nuget](https://www.nuget.org/packages/XCCDFParser/)

    Install-Package XCCDFParser

Or

    dotnet add package XCCDFParser

Or build from source. Tested on Visual Studio 2017.
