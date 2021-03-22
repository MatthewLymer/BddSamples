Feature: Allow user to use the basic math operators
Scenario: Addition
  Given a new instance of a calculator
  When I add <operand1> and <operand2> together
  Then the result should be <result>
  Examples:
  | operand1 | operand2 | result |
  | 0 | 0 | 0 |
  | 5 | 3 | 8 |
  | -3 | -2 | -5 |

