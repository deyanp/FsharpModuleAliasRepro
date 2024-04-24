module ModuleAliasRepro.Program

open FsToolkit.ErrorHandling
open ModuleAliasRepro1
open ModuleAliasRepro2

[<EntryPoint>]
let main argv =
    let x = Module1.someF () // works
    let y = Module1.someF2 () // works

    let a: Result<int, string> = ResultA.retnV2 1  // works
    let b: Validation<int, string> = ResultA.retn 2 // does not work

    0 // return an integer exit code


