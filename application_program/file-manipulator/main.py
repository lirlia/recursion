import sys
from os.path import exists

# inputpath outputpath: inputpath にあるファイルを受け取り、
# outputpath に inputpath の内容を逆にした新しいファイルを作成します。
def reverseCmd(contents, o):
  reversedList = list(reversed(contents))
  o.write(''.join(reversedList))

def copyCmd(contents, o):
  o.write(contents)

def duplicateContentsCmd(i, contents,count):
  i.write(contents * count)

def replaceStringCmd(i, contents,substitute, replacement):
  i.truncate(0)
  i.write(contents.replace(substitute, replacement))


def main():

  command = sys.argv[1]
  inputpath = sys.argv[2]

  if not exists(inputpath):
    print("Input file does not exist")
    sys.exit(1)

  with open(inputpath, "r+") as i:
    contents = i.read()

    if command == "reverse" or command == "copy":
      outputpath = sys.argv[3]

      if inputpath == outputpath:
        print("Input and output paths must be different")
        sys.exit(1)

      with open(outputpath, "a") as o:
        if command == "reverse":
          reverseCmd(contents, o)
        elif command == "copy":
          copyCmd(contents, o)

    elif command == "duplicate-contents":
      count = int(sys.argv[3])
      duplicateContentsCmd(i, contents, count)

    elif command == "replace-string":
      substitute = sys.argv[3]
      replacement = sys.argv[4]
      replaceStringCmd(i, contents, substitute, replacement)

    sys.exit(0)

if __name__ == "__main__":
    main()
