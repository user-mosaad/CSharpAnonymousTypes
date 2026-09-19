# C# Anonymous Types

Anonymous types provide a convenient way to encapsulate a set of read-only properties into a single object without defining a named type first. The compiler generates a type name at compile time that you can't access in your source code. The compiler infers the type of each property.

Create anonymous types by using the new operator together with an object initializer.

## Declare anonymous types with var
Because the compiler generates the type name and you can't access it in source code, you must use `var` to declare the local variable. You can't specify the type name explicitly.

## Equality
Two anonymous type instances that have the same property names and types in the same order share the same compiler-generated type.

## Nested anonymous types
Anonymous types can contain other anonymous types as property values.

## Characteristics
- The compiler generates them as `internal sealed class` types that derive from `Object`.
- All properties are `public` and read-only.
- Anonymous types support `with` expressions for nondestructive mutation.
- The compiler generates value-based `Equals`, `GetHashCode`, and `ToString` overrides.
- Anonymous types support expression trees, while tuples don't.

## Limitations
- You can't use them as method return types, method parameters, or field types because you can't name the type.
- They're scoped to the method where you declare them.
- You can't add methods, events, or custom operators.
- Properties are always read-only; anonymous types don't support mutable properties.

## When to use tuples instead
For most new code, consider using tuples instead of anonymous types. As value types, tuples provide better performance. They also provide deconstruction support and more flexible syntax. Anonymous types remain the better choice when you need expression tree support or reference-type semantics.
