ArrayList er ikke type-sikker og man kan lagre objekter av ulike typer i samme liste.
List er type-sikker, og man spesifiserer typen på forhånd ved deklarasjon.

ArrayList bruker boxing/unboxing (konvertering når de legges til og konvertering når de hentes ut) og dette gir overhead.
List bruker ikke dette, og er derfor raskere og mer effektiv.

Mine tanker rundt dette uten å lese alt for mye om det, er at ArrayList er utdatert og jeg ser egentlig ikke noen god grunn til å bruke det over List.
