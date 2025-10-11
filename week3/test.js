function calculate(text) {   
    var stack = [];
    var items = text.split(" ");
    // console.log(items);
    for (var i in items) {
        if (items[i] == "+" || items[i] == "-" || items[i] == "*" || items[i] == "/") {
            if (stack.Count < 2) {
                return "Invalid Case 1!";
            }
            var op2 = stack.pop();
            var op1 = stack.pop();
            var res;
            if (items[i] == "+") {
            res = op1 + op2;
                }
            else if (items[i] == "-") {
                res = op1 - op2;
            }
            else if (items[i] == "*") {
                res = op1 * op2;
            }
            else {
                if (op2 == 0) {
                    return "Invalid Case 2!";
                }
                res = op1 / op2;
            }  
            stack.push(res);
        }
        else if (items[i].match(/^\d+$/)) {
            stack.push(JSON.parse(items[i]));
        }
        else if (items[i] == "") {
        }
        else {
            return "Invalid Case 3!";
        }
    }
    if (stack.length != 1) {
        return "Invalid Case 4!";
    }

    return stack.pop();
}

console.log(calculate("5 3 7 + *"));