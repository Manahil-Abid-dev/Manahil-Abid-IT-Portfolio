// Get display input
let display = document.getElementById("display");

// Variables to store numbers and operator
let num1 = "";
let operator = "";
let num2 = "";

// Function to append number
function appendNumber(number) {
    display.value += number; // show on display

    if (operator === "") {
        num1 += number; // build first number
    } else {
        num2 += number; // build second number
    }
}

// Function to append operator
function appendOperator(op) {
    if (num1 === "") return;          // don't allow operator first
    if (operator !== "") return;      // don't allow multiple operators

    operator = op;
    display.value += op;
}

// Function to calculate result
function calculateResult() {
    if (num1 === "" || operator === "" || num2 === "") return; // prevent error

    let result = 0;
    let n1 = parseFloat(num1);
    let n2 = parseFloat(num2);

    if (operator === "+") result = n1 + n2;
    else if (operator === "-") result = n1 - n2;
    else if (operator === "*") result = n1 * n2;
    else if (operator === "/") result = n1 / n2;

    display.value = result;

    // reset for next calculation
    num1 = result.toString();
    operator = "";
    num2 = "";
}

// Function to clear display
function clearDisplay() {
    display.value = "";
    num1 = "";
    operator = "";
    num2 = "";
}
