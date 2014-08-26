namespace MonoDevelop.DocFood.FSharp

open System
open ICSharpCode.NRefactory
open ICSharpCode.NRefactory.TypeSystem

type DocGenerator() = 
    inherit MonoDevelop.Projects.Text.DocGenerator()

    member x.FillDocumentation(xmlDoc: string) =
        if System.String.IsNullOrEmpty xmlDoc then
            ()
        else
            let sb = System.Text.StringBuilder()
            sb.Append "<root>" |> ignore
            let mutable wasWs = false
            for ch in xmlDoc do
                if ch = '\r' then
                    ()
                elif ch = ' ' || ch = '\t' then
                    if not wasWs then
                        sb.Append ' ' |> ignore
                        ()
                    wasWs <- true
                    ()
                else
                    wasWs <- false
                    sb.Append ch |> ignore
            sb.Append("</root>") |> ignore

            
    member x.Init(aMember: IEntity) =   
        if aMember = null then
            raise (ArgumentException("aMember"))

    override x.GenerateDocumentation(aMember : IMember, linePrefix: string) =
        DocumentBufferHandler.GenerateDocumentation(null, aMember, "", linePrefix)