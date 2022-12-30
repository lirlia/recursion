import markdown
import sys

def main():
    sys.args = sys.argv[1:]
    if len(sys.args) != 3:
        print("Usage: python3 markdown.py markdown input.md output.html")
        sys.exit(1)

    command = sys.args[0]
    inputpath = sys.args[1]
    outputpath = sys.args[2]

    with open(inputpath, "r") as i:
        contents = i.read()
        html = markdown.markdown(contents)

    with open(outputpath, "w") as o:
        o.write(html)


if __name__ == "__main__":
    main()
