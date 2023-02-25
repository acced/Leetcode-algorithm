# Difference between virtual and abstract properties in C#




- Use an `abstract` property when you have  `no default implementation` and when derived classes must implement it.

- Use a `virtual` property when you have an implementation in the `base` class but want to `allow` overriding.

- Use the override keyword to override a member. Mark the member as `sealed override` if it `should not be overridden again`.

- Don't mark the property as abstract or virtual if you don't want it to be overridden.

- Use the new keyword to hide a non-abstract, non-virtual member (this is rarely a good idea).