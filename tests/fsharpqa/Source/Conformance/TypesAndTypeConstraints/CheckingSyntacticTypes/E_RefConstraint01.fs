// #Regression #Conformance #TypeConstraints 
// Verify error when reference constraint is not satisifed
//<Expects id="FS0001" status="error">A generic construct requires that the type 'int' have reference semantics, but it does not, i.e. it is a struct</Expects>

let isReference (x : 'a when 'a : not struct) = ()

// Works
do isReference "a string"

// Fails
do isReference 42

exit 1
