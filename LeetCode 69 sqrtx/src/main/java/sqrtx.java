public class sqrtx {
    public int mySqrt(int x) {
        int result = 0;
        while (true) {
            if (result*result < x) {
                result += 1;
            } else if (result*result == x) {
                break;
            }
            else {
                result -= 1;
                break;
            }
        }
        return result;
    }
}
