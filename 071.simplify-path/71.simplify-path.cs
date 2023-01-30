/*
 * @lc app=leetcode id=71 lang=csharp
 *
 * [71] Simplify Path
 */

// @lc code=start
public class Solution {
    public string SimplifyPath(string path) {
        var stack = new Stack<string>();
    var dirs = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
    foreach (var dir in dirs) {
        if (dir == ".") continue;
        else if (dir == "..") {
            if (stack.Count > 0) stack.Pop();
        } else {
            stack.Push(dir);
        }
    }
    return "/" + string.Join("/", stack.Reverse());
    }
}
// @lc code=end

