open System

let solution_001():int = 
	[0..999]
	|> List.filter (fun x -> x %3 =0 || x %5 =0)
	|> List.sum()

[<EntryPoint>]
let main argv = 
	Console.WriteLine(solution_001) // Prints 233168
