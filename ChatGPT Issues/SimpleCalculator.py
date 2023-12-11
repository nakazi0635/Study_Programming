# チャレンジ：シンプルな電卓プログラム
# 目標
# コマンドラインから入力を受け取り、基本的な算術演算
# （足し算、引き算、掛け算、割り算）を実行するシンプルな電卓プログラムを作成します。

# 要件
# ユーザーはコマンドラインから2つの数値と1つの演算子（+, -, *, /）を入力できるようにします。
# プログラムはこれらの入力を受け取り、適切な演算を行い、結果を表示します。
# 入力された演算子が無効な場合、ユーザーにエラーメッセージを表示します。
# ゼロによる除算が試みられた場合は、ユーザーにエラーを通知します。

# 追加の挑戦（オプション）
# プログラムが継続して入力を受け付け、ユーザーが終了を選択するまで動作を続けるようにします。
# 入力の検証を強化して、ユーザーが無効な数値（文字列など）を入力した場合に適切に処理します。

def get_user_input(message):
    while True:
        try:
            return int(input(message))
        except ValueError:
            print("ERROR: 数値以外を入力しないでください。")

def get_user_operator(message):
    while True:
        operator = input(message)
        if operator in ["+", "-", "*", "/"]:
            return operator
        print("ERROR: 無効な演算子です。+ - * / のいずれかを入力してください。")

def int_calculation_input(num1, num2, operator):
    if operator == "+":
        return num1 + num2
    elif operator == "-":
        return num1 - num2
    elif operator == "*":
        return num1 * num2
    elif operator == "/":
        if num2 != 0:
            return num1 / num2
        else:
            raise ValueError("ERROR: 0で割ることはできません。")
    

def validate_input():
    while True:
        try:
            num1 = get_user_input("一つ目の数字を入力してください\n")
            num2 = get_user_input("二つ目の数字を入力してください\n")
            operator = get_user_operator("演算子（+, -, *, /）を入力してください\n")
            ans = int_calculation_input(num1, num2, operator)
            print(ans)
        except ValueError as e:
                print(str(e))
        
        print("もう一度計算しますか？（y/n）")
        if input() == "n":
            break




def main():
    validate_input()

import unittest

class TestValidateInput(unittest.TestCase):
    def test_validate_input(self):
        num1 = 1
        num2 = 2
        operator = "+"
        result = int_calculation_input(num1, num2, operator)
        answer = 3
        self.assertEqual(result, answer)

        num1 = 9999
        num2 = 9
        operator = "/"
        result = int_calculation_input(num1, num2, operator)
        answer = 1111.0
        self.assertEqual(result, answer)


if __name__ == '__main__':
    main()
    unittest.main()