while True:
    print("\n" + "∞" * 40)
    print("CALCULATE:")
    try:
        userIn1 = int(input("First number:"))
    except ValueError:
        print("--ERROR!!:Please enter a valid number--")
        continue

    try:
        userIn2 = int(input("Second number:"))
    except ValueError:
        print("--ERROR!!:Please enter a valid number--")
        continue

    userInop = input("Operator (+, -, *, /):")

    if userInop == "+":
        add = userIn1 + userIn2
        print(add)
    elif userInop == "-":
        sub = userIn1 - userIn2
        print(sub)
    elif userInop == "*":
        mult = userIn1 * userIn2
        print(mult)
    elif userInop == "/":
        div = userIn1 / userIn2
        print(div)
    else:
        print("SyntaxError!!, Please enter a correct operator")

    print("\n" + "∞" * 40)
