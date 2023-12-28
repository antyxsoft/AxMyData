@echo off

REM Generates a single output file per input file
REM The output file contains multiples classes
REM We need this in case some class is not generated when generating a file for each class

REM  Options
REM		/ns		Namespace
REM		/gsf	Generate Separate Files
REM		/ap+	Auto Properties
REM		/eit+	Exclude types from included Schemas in generation
REM		/xa+	Generate xml attributes
REM		/co 0	Numeric. Code Options. Various options to use when generating .NET types (see .net CodeGenerationOptions Enum)

@echo on
cd C:\tools\xsd2code\MyData_1.8

C:\tools\xsd2code\xsd2code paymentMethods-v1.0.8.xsd /ns MyDataXsd /ap+ /eit+ /xa+ /co 0
C:\tools\xsd2code\xsd2code response-v1.0.8.xsd /ns MyDataXsd /ap+ /eit+ /xa+ /co 0
C:\tools\xsd2code\xsd2code incomeClassification-v1.0.8.xsd /ns MyDataXsd /ap+ /eit+ /xa+ /co 0
C:\tools\xsd2code\xsd2code expensesClassification-v1.0.8.xsd /ns MyDataXsd /ap+ /eit+ /xa+ /co 0
C:\tools\xsd2code\xsd2code InvoicesDoc-v1.0.8.xsd /ns MyDataXsd /ap+ /eit+ /xa+ /co 0
C:\tools\xsd2code\xsd2code requestedInvoicesDoc-v1.0.8.xsd /ns MyDataXsd /ap+ /eit+ /xa+ /co 0
C:\tools\xsd2code\xsd2code RequestedProviderDoc-v1.0.8.xsd /ns MyDataXsd /ap+ /eit+ /xa+ /co 0

pause