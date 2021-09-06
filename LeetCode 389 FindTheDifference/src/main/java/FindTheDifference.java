import java.util.HashSet;

public class FindTheDifference {

    public char findTheDifference(String s, String t) {
        HashSet<Character> stringS = new HashSet<Character>();
        for (char c: s.toCharArray()) {
            stringS.add(c);
        }
        for (char c: t.toCharArray()) {
            if (!stringS.contains(c)) {
                return c;
            }
        }
        return '\0';
    }
}
