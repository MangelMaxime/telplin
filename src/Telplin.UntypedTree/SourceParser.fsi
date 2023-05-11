module Telplin.UntypedTree.SourceParser

open Fantomas.Core.SyntaxOak

type TypeTupleNode with

    member Types : Type list

val (|TParen|_|) : Type -> Type option

val (|PropertyGetSetWithExtraParameter|_|) :
    md : MemberDefn -> (MemberDefnPropertyGetSetNode * PropertyGetSetBindingNode * PropertyGetSetBindingNode) option
