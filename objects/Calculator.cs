
public enum Operator
{
    ADD = 1, SUBTRACT = 2, MULTIPLY = 3, DIVISION = 4
}

public class Calculator
{

    public bool Run()
    {
        float operand, input1, input2;
        PrintInstruction();
        if (!WaitForInput(null, out operand) || operand < 1 || operand > 5)
        {
            PrintInvalidInput();
            return false;
        }

        if (!WaitForInput("Enter 1st input", out input1))
        {
            PrintInvalidInput();
            return false;
        }

        if (!WaitForInput("Enter 2st input", out input2))
        {
            PrintInvalidInput();
            return false;
        }

        float result = Solve((int)operand, input1, input2);
        PrintResult(result);
        return true;
    }

    public float Solve(int operand, float input1, float input2)
    {
        float result;
        switch ((Operator)operand)
        {
            case Operator.ADD:
                result = input1 + input2;
                break;
            case Operator.DIVISION:
                result = input1 / input2;
                break;
            case Operator.MULTIPLY:
                result = input1 * input2;
                break;
            case Operator.SUBTRACT:
                result = input1 - input2;
                break;
            default:
                result = 0;
                break;
        }

        return result;
    }

    private void PrintResult(float result)
    {
        Console.WriteLine("The result is {0}", result.ToString("n2"));
    }

    private void PrintInvalidInput()
    {
        Console.WriteLine("Invalid Input");
    }

    private void PrintInstruction()
    {
        Console.WriteLine("Enter the action to be performed");

        for (int i = 1; i <= 4; i++)
        {
            Operator operand = (Operator)i;
            String operandStr = operand.ToString();
            operandStr = operandStr[0] + operandStr.Substring(1).ToLower();
            Console.WriteLine("Press {0} for {1}", i, operandStr);
        }
    }

    private bool WaitForInput(string? instruction, out float result)
    {
        if (instruction != null) Console.WriteLine(instruction);
        string? input = Console.ReadLine();

        return float.TryParse(input, out result);
    }
}