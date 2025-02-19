# F# Mutability and Immutability Bug

This example demonstrates a common mistake in F#:  incorrectly assuming mutability where immutability is enforced.

**Problem:** The `result` variable is assigned a value initially, then a second assignment attempts to change the value. This results in a compile-time error because, by default, variables in F# are immutable.