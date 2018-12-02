module AdventOfCode2018.Day02
open System
open System.Collections.Generic

let run() =
    let input = "bpacnmelhhzpygfsjoxtvkwuor
biacnmelnizqygfsjoctvkwudr
bpaccmllhizyygfsjoxtvkwudr
rpacnmelhizqsufsjoxtvkwudr
bfacnmelhizqygfsjoxtvwwudp
bpacnmelhizqynfsjodtvkyudr
bpafnmelhizqpgfsjjxtvkwudr
bpackmelhizcygfsjoxtvkwudo
bmacnmilhizqygfsjoltvkwudr
bpafnmelhizuygfsjoxtvkwsdr
boacnmylhizqygfsjoxtvxwudr
bpbcjmelhizqygfsjoxtgkwudr
bpacnmglhizqygfsjixtlkwudr
bpacnmclhizqygfsjoxtvkwtqr
bpacnmelhczqygtsjoptvkwudr
bpacnmelhizqywfsaoxtvkbudr
apacnmelhizqygcsjoxtvkwhdr
bpacnmelrizqygfsbpxtvkwudr
tpkcnmelpizqygfsjoxtvkwudr
bpacnmelhizqlgfsjobtmkwudr
npacnmelhizqygffjoxtvkwudf
bpacnmeehqzqygqsjoxtvkwudr
bpecnmelhizqigfsjvxtvkwudr
bpacnmelhizqysfsjoxtvkdfdr
bpacnfelhkzqygfsjoxtvkwfdr
bpacnbelvizqygfsjoxthkwudr
bpacnoelhizqygfejoxtvkwudn
bpacnmelhizqygfzpkxtvkwudr
bpahnmelhizqyufsjoxmvkwudr
bpacnmelhizqygfsnoxtvkwmmr
bpacnmelhizqygfsjoatvkludf
bpacnmylhizqygfsjlxtvksudr
bpacnmekhpzqygysjoxtvkwudr
bpacnselhizqogfswoxtvkwudr
bpacnmelhizqprfsjoxwvkwudr
bpatnmelhinqygfsjoctvkwudr
bpacnqelhqzqygfsxoxtvkwudr
bpabnmelhiyqygfsjoxtykwudr
bpacnivlhizqygfsjoxtviwudr
bpkcnmylhizqygfsjoxtvkwcdr
bpafnmflhizqygtsjoxtvkwudr
bpachmelhizqygfsjixtvkwudg
bpacymelhizqygfsjoxtykwuar
bpacnkelhizqdgfsjoxtskwudr
bpacnmezhizqggbsjoxtvkwudr
bpacnmqlhizqygrsjoxzvkwudr
bpaczmelhizqyhfsjoxfvkwudr
bdacnmelhyzqygusjoxtvkwudr
bpacbmelhizqywfsjostvkwudr
bpacnmelhihzygfstoxtvkwudr
bpactmelhizqygfsjcxtvkwydr
bkacnmethizqytfsjoxtvkwudr
bpacnmalhizqydfskoxtvkwudr
spacnmelbizqygfsjoxdvkwudr
lpalnmelhizoygfsjoxtvkwudr
bpacjmeghizqygfsjoxtviwudr
bpacnmeqhizxygfsjoxgvkwudr
bpacnmelhizqygosjoxtvkkuhr
bpacnmelhiznbxfsjoxtvkwudr
bgacnmelhizqygfsjbxivkwudr
bpacnmelhizqygfjjowtvswudr
bpacnmelhizqygfsjovtgkmudr
bpacnmelcmzqygfspoxtvkwudr
bpvcnmelhizqyvfcjoxtvkwudr
bpacnmeahizqjgfsjoxtvkwukr
bpacnoelwizqygfsjoxtvkaudr
xpacnmelhizqygfsjoxdvkwedr
mpacnmelqizqygfsjoxtvkwudx
bppcnmelhizqygfsjfxtvkhudr
bpacnmclhizqyhfsjaxtvkwudr
opacsmelhizqygfsjmxtvkwudr
bpafnmelhizqjgfsjoxtvkrudr
bpdcnmilhizqygfsjoxtvkludr
bpainmelhizqygfsjtntvkwudr
bradnmelhizqygfsjextvkwudr
bpacnmelhizqygfmsoxtvkwudg
bpacneelhizqygvrjoxtvkwudr
bpacnpelhizqygfsjoxyvkwudf
bpacnmelhizqygfsqoqtvkwodr
bpacnmelhizjyghsjoxcvkwudr
bpacnmelmibqygfsjoxtvnwudr
jpacnmelaizqygfwjoxtvkwudr
zpachmelhizqygfsjsxtvkwudr
bpacnmelfizqykfsjomtvkwudr
bpacnmllwizqygfsjoxtvkwusr
bpaynmelhizqygfsjoxtvowcdr
jpacnmqlhizqygfsjoxtvknudr
bpacxmelhizqyffsjoxtvkwugr
apawnmelhizqygfsjtxtvkwudr
mpacnmelhitqigfsjoxtvkwudr
bpacnmelhhzqygfsjoxtvkyzdr
gpacnmelhizqynfsjoxtvkwudm
bnacnkelhizqygfsjoxtpkwudr
bpacnmelfizqygfsumxtvkwudr
bpacnmelhisqygfsjohtvowudr
bpacnmelhimqygxsjoxtvkwudn
bpscnmeliizqygfsjoxtvkwunr
qpacnmelhizqycfsjoxtvkwndr
bpacnmelhijqygfsjohtvkyudr
bpacnmelhizqykfsjkxtvknudr
bpacnqilhizqygfsjoxtvkoudr
bpacnmelhizqzgmsjoxtvkwurr
bpdcnmelhizqygfsjoutukwudr
bpecnmeghizqygfsjoxgvkwudr
bpicnmelhizqygfrjoxtvlwudr
bpacnmelhizfygfsroxtvkwodr
buacnmelhizqygjsjoxtvkvudr
bpacnmelhixqykfsjoxtvrwudr
bpacnmelhizqygvejcxtvkwudr
bpacnmjlhizqylfsjoxtvkwuor
qpacnmelhizqygfsjoxfdkwudr
bpfcnmemhizqygfsjoxtvknudr
bpacnmelhizqoffsjqxtvkwudr
hpacnielhiqqygfsjoxtvkwudr
gpacnmelhizqygfsewxtvkwudr
bpacnmellizqylxsjoxtvkwudr
bpacnmenhizqymfsjoxtvkmudr
bpacnfelhizqygcsjoltvkwudr
bpacnmelhqqqygfsjoxtvkuudr
bplgnmelhiqqygfsjoxtvkwudr
bpacnzelhizqygfgjoxtvnwudr
bpacnmelhizqygfsjoktvknunr
bpacnmdlhioqygfnjoxtvkwudr
epacnmelwizqyjfsjoxtvkwudr
bpacxmelhazfygfsjoxtvkwudr
bpacnmejhezqygfsjoxtskwudr
bpacnqelhihqyzfsjoxtvkwudr
bpacnbelhizqyrfsjoxtvkmudr
bpacnmelhizqygfsjoxtylwzdr
bpacnmelwizqygfsjodtvkhudr
bpacnnelhizqygfsjoxtwkwadr
bpacimelhizqygfsnoxtvkwuor
bpacnmelhizqyaasjoxtlkwudr
bpacnmelhizqyeffjoxtvkwuds
bpacnmenhizqygxscoxtvkwudr
bpacnmelhidqygfsjowtskwudr
bpacnmeliizqygfsjoxhvkwucr
bpacimelhizqygfsjoxtvktuwr
bpainmelhhzqygfsjzxtvkwudr
bpacamelhizqygfsjogtvkwbdr
bpccnmelgizqygfsjoxtykwudr
bpacnmelhizwegfsjoxtvkwadr
bpackmelhbzqygqsjoxtvkwudr
bpacymeihizqyffsjoxtvkwudr
bpacnielhczqygfsjoxtvkwudk
bpacnmejhizqygffjoxjvkwudr
ppacnmelhizqygfsjoxtigwudr
bpjcnmolhizqygfsjoxtvkwndr
bpacnmelcizqygrsjoxtakwudr
cpawnmelhizqygfsjoxmvkwudr
bwacnmelhizqygesjoxtakwudr
bpacnmelhizqygfsjexsvkwddr
bpaunmelhiuqygfsjoxtvkwtdr
bpacnmellimqygfsjextvkwudr
bpacnmerhizqygfsaoxvvkwudr
bpacnmglhizqygfsjixtukwudr
ppacnmelhizqygfsjoxtvkdudp
bpacnmedhizqygukjoxtvkwudr
bpccnmelhizqngfsjoxtvkwadr
bgacnmeldizqygfscoxtvkwudr
bpacngelhizsygfsjoxtvkwkdr
bpacnpelhizqygfsjoxctkwudr
bpacnmylhizqygfcjoxtvkwmdr
npacnmelhizqygfsjoxtwkwuds
bpaxnmelhizqydfsjoxyvkwudr
bpacnhelhizjygfsjoxtvkmudr
bpacnkelhczqygfnjoxtvkwudr
bfacnmelhizrygfsjoxtvkwodr
bpycnmelhizqygfofoxtvkwudr
qpacpselhizqygfsjoxtvkwudr
bpvcnmelhezqygfsjoxttkwudr
bpacnmwlhizqygfijoxtmkwudr
bsacnmelhikqygfsjoxttkwudr
bpccnxelhizqyafsjoxtvkwudr
bpacnmelhizqygfswhxtvewudr
vpacnmzlhizqygfsvoxtvkwudr
bpacnmelhihqygfsjoxtvkqurr
bpacnmelhixqygazjoxtvkwudr
bpavnmelhizqygfsjozpvkwudr
bpacnmclhizuygfsjoxmvkwudr
bpacnmelhizryufsjoxtkkwudr
bpacnmelhtzqygfsjobtvkwufr
bpacnmelhizqmlfsjoxtvkwudq
bpaaneelhizqygfsjlxtvkwudr
bpacnmelhxzqygfsjoxthkwuhr
bpacnmeshizqygfcjoxtvkwude
bpacnzqlhizqygfsxoxtvkwudr
bgaanmelhizqycfsjoxtvkwudr
bpacnmexhizqygfsroxtvkwudn
bpmmnmelhizqygfajoxtvkwudr
bpacnmelhizqylfsjoxtckwhdr
bpicnmelhizqyrfsjoxtvkwudi
zpacnmelhizvycfsjoxtvkwudr
bpamnmkllizqygfsjoxtvkwudr
bpacnmelhrzqyrfsjoxgvkwudr
bpadnmelhczqygfsjoxtlkwudr
bpacrmelhizqygrsjoxtvkiudr
lpacnmelhizqygfsjoxtgkwxdr
fpacnmalhiuqygfsjoxtvkwudr
bpacnmelhizqygfsjixtvfwcdr
bpccnmelhxzqygfkjoxtvkwudr
bpacnmepaizqygfsjoctvkwudr
tpacnmelhivqygfsxoxtvkwudr
kpacnfelhitqygfsjoxtvkwudr
baacnzelhizqygfsjoxtvkwudx
bcycnmeghizqygfsjoxtvkwudr
wpacotelhizqygfsjoxtvkwudr
bpacnmsshizqygrsjoxtvkwudr
blacnmelhizqygfsjoxtykwvdr
bkacnmelhizqygfsjoxuvkludr
bpacnmelhizaugfsjoxtvhwudr
fpavnmelhizqygfsgoxtvkwudr
bpachmelnizqygfsjextvkwudr
bpacnmelhizqpgfsjoxtvkwldu
bpacnmelhizqygfsloftvywudr
bpacntelhvzqygfejoxtvkwudr
bpacnmeldizqygfsjmxtvkdudr
byacnmelhizqygfsjsxtvkwudh
bpacnmellizqygssxoxtvkwudr
bpacnmelhizqygfsjootvknuir
bpacnmelhitqjgfsjoxivkwudr
bpacnmelhazaygfsjoxtvfwudr
bpacnzenhizqygfsjzxtvkwudr
bpacnmelhizqypfsdoxtvkwuar
bpannmelhizqygnsjoxtvkwndr
bracnmeldizsygfsjoxtvkwudr
bpacnmelhizwygfsjugtvkwudr
bpatnmelhizqygfsjoytvkwulr
upacnmelhizqygfsjurtvkwudr
bpaenmezhizqygfsjostvkwudr
bpacnmelhizpygfsjodhvkwudr
bpacnmelhizqygfsjogtvkguwr
bpacnmelhisqygfsjoxtpkuudr
bxacnmelhizqygfsjdxtvkfudr
bpacnmelhizqygfsjohqvkwudu
bzacnmtlhizqygfsjoxsvkwudr
bpacnmplhixrygfsjoxtvkwudr
bpacnmelhizqhgfsjomtvkwudg
bpacnmezhizqygfsjxxtykwudr
bpacnmwlhizqygfujoxtzkwudr
tpacnmelhizqygfsjoxkvpwudr
bpawsmenhizqygfsjoxtvkwudr
bpacnmelhizqtgfsjoxttkwuqr
bpkcbmelhizqygfsjoxtvkwucr
bpacfmekhizqygfsjoxtvkwuds
bpacnmethizqynfajoxtvkwudr
bpocnmclhizqygfsjoxtvkwukr
zpacnmwlhizqygfsjoxzvkwudr
bpacpoelhqzqygfsjoxtvkwudr
bpacnlelhizqyzfsjoxtvkwukr"
    
    let splitInput = input.Split(Environment.NewLine)
    
    let part1 () = 
        let charCounts = splitInput |> Seq.map (fun x ->
            let grouped = x.ToCharArray() |> Array.countBy id |> Array.map snd
            let contains2 = if (grouped |> Array.contains 2) then 1 else 0
            let contains3 = if (grouped |> Array.contains 3) then 1 else 0
            (contains2, contains3)
        )
        
        let checksum = (charCounts |> Seq.map fst |> Seq.sum) * (charCounts |> Seq.map snd |> Seq.sum)
        
        printfn "%i" checksum

    let similarity (s1:string) (s2:string) =
        let zipped = Array.zip (s1.ToCharArray()) (s2.ToCharArray())
        zipped |> Seq.sumBy (fun x -> if (fst x) = (snd x) then 1 else 0)

    let compare (previous: (string*int*string) list) value =
        let newEntry =
            match previous with
            | [] -> value,0,""
            | _ ->
                previous
                |> Seq.map (fun (previousValue,_,_) -> value,(similarity previousValue value), previousValue)
                |> Seq.maxBy (fun (_,x,_) -> x)
        newEntry :: previous
    
    let (s1,_,s2) = splitInput |> Seq.fold compare [] |> Seq.maxBy (fun (_,x,_) -> x)
    
    let result = Seq.map2 (fun c1 c2 -> if c1=c2 then Some (c1) else None ) (s1.ToCharArray()) (s2.ToCharArray()) |> Seq.choose id |> Array.ofSeq |> String
    
    printfn "%s" result
