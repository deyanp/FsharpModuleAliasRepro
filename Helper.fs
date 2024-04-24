namespace ModuleAliasRepro

open FsToolkit.ErrorHandling

module ResultA = Validation

[<RequireQualifiedAccess>]
module ResultA =
    let retnV2 x = Result.Ok x
  
