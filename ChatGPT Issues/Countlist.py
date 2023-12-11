# 問題:
# あなたは与えられたリスト内の各要素の出現回数を数えるPython関数を書く必要があります。この関数は、リスト内の各要素とその出現回数を辞書形式で返すべきです。

# 具体的なタスク:
# 関数 count_duplicates を定義してください。
# この関数は、任意の要素（数値、文字列など）を含むリストを引数として受け取ります。
# 関数は、リスト内の各要素の出現回数をカウントし、要素をキーとし、その出現回数を値とする辞書を返す必要があります。

# 例:
# 入力: ['apple', 'banana', 'apple', 'orange', 'banana', 'apple']
# 出力: {'apple': 3, 'banana': 2, 'orange': 1}

def count_duplicates(items):
    counts = {}
    for i in items:
        if i in counts:
            counts[i] += 1
        else:
            counts[i] = 1
    return counts

import unittest

class TestConutDuplicates(unittest.TestCase):
    def test_count_duplicates(self):
        result = count_duplicates(['apple', 'banana', 'apple', 'orange', 'banana', 'apple'])
        answer = {'apple': 3, 'banana': 2, 'orange': 1}
        self.assertEqual(result, answer)

if __name__ == '__main__':
    result = count_duplicates(['apple', 'banana', 'apple', 'orange', 'banana', 'apple'])
    print(result)
    unittest.main()