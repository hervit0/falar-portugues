module FalarType

type World =
  {
    Portuguese : string
    English : string
  }

type Language =
  | Portuguese
  | English
  | Both

type Guess =
  {
    Portuguese : string
    English : string
    Answer : string
    Correctness : string
  }
