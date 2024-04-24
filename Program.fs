module ModuleAliasRepro.Program

open FsToolkit.ErrorHandling

[<EntryPoint>]
let main argv =

    let a: Result<int, string> = ResultA.retnV2 1  // works
    let b: Validation<int, string> = ResultA.retn 2 // does 

    // For more information see https://aka.ms/fsharp-console-apps
    printfn "Hello from F#"
