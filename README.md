
# OldPhonePad 

## 📋 Problem Statement

Simulate typing text on an old mobile phone keypad based on numeric input using the following rules:

- Numbers map to letters: 
  - 2 → A, 22 → B, 222 → C, etc.
- A pause (` `) separates characters on the same key.
- `*` acts as backspace.
- `#` marks the end of input and should always be present.

Example:
- `4433555 555666#` → `HELLO`

## 🧠 Solution Design

Implemented a static method:

```csharp
public static string OldPhonePad(string input)
```

- Uses a dictionary to map keys to character sequences.
- Parses input while respecting pauses, backspaces, and send indicators.
- Includes helper method to translate numeric sequences to characters.

## ✅ Examples

| Input                         | Output |
|------------------------------|--------|
| 33#                          | E      |
| 227*#                        | B      |
| 4433555 555666#              | HELLO  |
| 8 88777444666*664#           | TI?ON  |

## 🧪 Testing

See `OldPhonePadTests.cs` for comprehensive test coverage.

## 🚀 Run

1. Open the project in Visual Studio.
2. Build the solution.
3. Run `Main()` in `Program.cs` or use a test runner for unit tests.

---

Author: Randall Vargas Li  
