import sys
import random

def myPrint(msg):
    sys.stdout.buffer.write(msg.encode())
    sys.stdout.flush()

def main():

    myPrint("please enter the min number: ")
    minNumByte = sys.stdin.buffer.readline()
    minNum = minNumByte.decode("utf-8")

    myPrint("please enter the max number: ")
    maxNumByte = sys.stdin.buffer.readline()
    maxNum = maxNumByte.decode("utf-8")

    if type(int(minNum)) != int or type(int(maxNum)) != int:
        myPrint("Please enter a number: ")
        sys.exit(1)

    minNum = int(minNum)
    maxNum = int(maxNum)

    if minNum > maxNum:
        myPrint("Min number is greater than max number")
        sys.exit(1)

    randNum = random.randint(minNum, maxNum)

    while True:
        myPrint("Please enter a number between " + str(minNum) + " and " + str(maxNum) + ": ")
        guessByte = sys.stdin.buffer.readline()
        guess = guessByte.decode("utf-8")

        if type(int(guess)) != int:
            myPrint("Please enter a number")
            sys.exit(1)

        guess = int(guess)
        if guess == randNum:
            myPrint("You guessed the number!")
            sys.exit(0)
        elif guess > randNum:
            myPrint("Your guess is too high")
        else:
            myPrint("Your guess is too low")


if __name__ == "__main__":
    main()
