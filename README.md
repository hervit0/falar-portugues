# Falar Portugues

:children_crossing: :bangbang:
> This is a personal training project, which is not meant to be deployed in a production environment. Therefore:
> - poor (or almost) no test coverage
> - no deployment or CI/CD strategy in place
> - some comments left (trying stuff basically)

## Run

```bash
cd falar
paket install
dotnet restore
dotnet build
dotnet run
```

A prompt should guide you from there. Have a good learning!

## Snippets

- Timestamp

```
let timestampWithZone =
    let zone = System.TimeZone.CurrentTimeZone.GetUtcOffset System.DateTime.Now
    let prefix = match (zone<System.TimeSpan.Zero) with | true -> "-" | _ -> "+"
    System.DateTime.UtcNow.ToString("yyyyMMddHHmmssffff") + prefix + zone.ToString("hhss");
"201811211202519196+0000"
```

- CsvType provider

```
type MyCsvType =
  CsvProvider<Schema = "A (int), B (string), C (date option)", HasHeaders=false>

let myRows =
  [ MyCsvType.Row(1, "a", None)
    MyCsvType.Row(2, "B", Some System.DateTime.Now) ]

let myCsv = new MyCsvType(myRows)
myCsv.Save(__SOURCE_DIRECTORY__ + "/../output/vocabulary.csv")
```

- Infinite prompt trick

```
let rec go =
    let argument = System.Console.ReadLine()
    printfn "%A" argument
    go ()
```

- A sequence

`let  = seq [{Portuguese = "um"; English = "one";}; {Portuguese = "dois"; English = "two";}]`
