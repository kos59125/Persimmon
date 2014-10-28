﻿module Persimmon.Sample

open Persimmon

let test1 = test "success test" {
  do! assertEquals 1 1
}

let test2 = test "failure test" {
  do! assertEquals 1 2
}

let tests = [
  test "success test(list)" {
    do! assertEquals 1 1
  }
  test "failure test(list)" {
    do! assertEquals 1 2
  }
]

let tests2 = [|
  test "success test1(array)" {
    do! assertEquals 1 1
  }
  test "success test2(array)" {
    do! assertEquals 1 1
  }
|]

let tests3 = seq {
  yield test "failure test(seq)" {
    do! assertEquals 1 2
  }
}