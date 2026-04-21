class Solution {

public boolean hasDuplicate(int[] nums) {

// 1. 建立 HashSet (記得 Java 中要指定泛型 <Integer>)

Set<Integer> seen = new HashSet<>();


// 2. 遍歷陣列

for (int num : nums) {

// 3. 嘗試加入 set，並判斷回傳值

if (seen.add(num) == false) {

// 如果加不進去，代表看到了重複的數字

return true;

}

}


// 4. 如果全部跑完都沒重複

return false;

}

}