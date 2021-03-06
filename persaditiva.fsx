let sumaDigitos n =
    let rec loop n ady vals =
        let actual = n % 10I
        if n > 0I then
            loop (n/10I) (ady + actual) (actual::vals)
        else ady, vals
    let res, sts = loop n 0I []
    List.map string sts|> String.concat "+"
    |> fun s -> printfn "%s = %A" s res
    res

let persAditiva n =
    let rec loop n veces =
        if n < 10I then veces
        else loop (sumaDigitos n) (veces + 1)
    loop (System.Numerics.BigInteger.Parse(n.ToString())) 0

persAditiva 12344562323232343I;