namespace ProjectEulerProblems.Problem_8;

public class Lib {
    public static long GreatestProduct(ReadOnlySpan<char> data, int digits) {
        var maxSum = 0L;
        var currentSum = 0L;

        var maxProduct = 1L;

        var _digits = new int[digits];

        for (var i = 0; i < _digits.Length; i++) {
            maxSum += data[i] - '0';
            maxProduct *= data[i] - '0';
            _digits[i] = data[i] - '0';
        }

        currentSum = maxSum;

        for (var i = 0; i < data.Length - digits; i++) {
            currentSum -= data[i] - '0';
            currentSum += data[i + digits] - '0';

            if (maxSum < currentSum) {
                var tempArray = new int[digits];
                var tempMaxproduct = 1L;
                for (var j = 0; j < tempArray.Length; ++j) {
                    tempArray[j] = data[i + j + 1] - '0';
                    tempMaxproduct *= data[i + j + 1] - '0';
                }

                if (tempMaxproduct > maxProduct) {
                    maxProduct = tempMaxproduct;
                    _digits = tempArray;
                    maxSum = currentSum;
                }
            }
        }

        return maxProduct;
    }
}