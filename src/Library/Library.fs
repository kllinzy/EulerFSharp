namespace Library


module Example =

    open Newtonsoft.Json

    let getJsonNetJson value =
        sprintf "I used to be %s but now I'm %s thanks to JSON.NET!" value (JsonConvert.SerializeObject(value))

