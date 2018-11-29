module Words

type WordAttributes = { English : string; Portuguese : string }
type Word = { Type : string; Id  : int; Attributes : WordAttributes }
type Data =  Word List
type Json = { Data : Data }

let um = {
  Type = "Word"
  Id  = 1
  Attributes = {
    English = "one"
    Portuguese = "um"
  }
}

let dois = {
  Type = "Word"
  Id  = 56
  Attributes = {
    English = "two"
    Portuguese = "dois"
  }
}

let data = [um; dois]
let staticResponse = { Data = data }

// {
//   "data": [
//     {
//       "type": "Word",
//       "id": "1",
//       "attributes": {
//         "english": "one",
//         "portuguese": "um"
//       }
//     },
//     {
//       "type": "Word",
//       "id": "2",
//       "attributes": {
//         "english": "two",
//         "portuguese": "dois"
//       }
//     }
//   ]
// }
