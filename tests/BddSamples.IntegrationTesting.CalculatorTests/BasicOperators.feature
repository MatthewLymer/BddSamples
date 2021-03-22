Feature: Basic Math Operators

Scenario: Addition

Given a new instance of a calculator
When I add <operand1> and <operand2> together
Then the result should be <result>

Examples:
| operand1 | operand2 | result |
| 0 | 0 | 0 |
| 5 | 3 | 8 |
| -3 | -2 | -5 |


Scenario: Multiplication

Given a new instance of a calculator
When I multiply <operand1> and <operand2> together
Then the result should be <result>

Examples:
|operand1|operand2|result|
|0|0|0|
|2|3|6|
|-1|5|-5|
|-2|-2|4|
