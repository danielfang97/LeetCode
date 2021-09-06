import java.util.HashMap;
import java.util.HashSet;

public class FindTheDifference {

    public char findTheDifference(String s, String t) {
        HashMap<Character, Integer> stringS = new HashMap<Character, Integer>();
        for (char c : s.toCharArray()) {
            if (stringS.containsKey(c)) {
                stringS.put(c, stringS.get(c)+1);
            } else {
                stringS.put(c, 0);
            }
        }
        for (char c : t.toCharArray()) {
            if (stringS.containsKey(c)) {
                if (stringS.get(c) > 1) {
                    stringS.put(c, stringS.get(c)-1);
                } else {
                    stringS.remove(c);
                }
            } else {
                return c;
            }
        }
        return '\0';
    }
}
