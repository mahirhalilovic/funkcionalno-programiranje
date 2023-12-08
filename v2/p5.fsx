// Napisati funkciju koja racuna cijenu potrosene elektricne energije.
// Cijena po kWh se racuna na osnovu kolicine potrosene energije
// Postoje 4 opsega potrosnje:
// Opseg A: 0 - 100 kWh - 0.1 KM po kWh
// Opseg B: 101 - 200 kWh - 0.15 po KWh
// Opseg C: 201 - 500 kWh - 0.2 po KWh
// Opseg D: preko 500 kWh - 0.25 po KWh
// Dodatno za preko 300 kWh potrosnje dodati 5 KM na ukupnu cijenu

let potrosnja : int = 400

let cijenaPE (pt : int) =
    if pt < 0 then printf "Greska u unosu!"
    elif pt >= 0 && pt < 101 then printf "Cijena: %.2f\n" (float32 pt * 0.1f)
    elif pt >= 101 && pt < 201 then printf "Cijena: %.2f\n" (float32 pt * 0.15f)
    elif pt >= 201 && pt < 301 then printf "Cijena: %.2f\n" (float32 pt * 0.2f)
    elif pt >= 301 && pt < 501 then printf "Cijena: %.2f\n" (float32 pt * 0.2f + 5.f)
    else printf "Cijena: %.2f\n" (float32 pt * 0.25f + 5.f)

cijenaPE potrosnja
