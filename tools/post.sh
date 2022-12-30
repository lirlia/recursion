#!/bin/bash

function encodeToURL() {
    local filename="$1"
    cat "$filename" | perl -ne 's/([^\w ])/"%".unpack("H2",$1)/eg;s/ /\+/g;print;' | perl -pe 's/\n/%0a/g' | perl -pe 's/%20/+/g' | perl -pe 's/%28/(/g' | perl -pe 's/%29/)/g' | perl -pe 's/%2a/*/g'
}

token="xxx"
session="xxx"

questioin_id="2"
url="https://recursionist.io/dashboard/problems/${questioin_id}/post/judge"
filename=$1
[[ -z $filename ]] && echo "Please provide a filename" && exit 1
code=$(encodeToURL "$filename")

language="${filename##*.}"

result=$(curl \
    -sS \
    "$url" \
    -H "cookie: recursion_session=$session" \
    --data-raw "_token=${token}&source_code=${code}&language=${language}")

echo "$result"
cat <<EOF | column -t
$(echo "$result" | jq -r '"結果 " + (.status | .description)')
$(echo "$result" | jq -r '"URL " + .submission_url')
$(echo "$result" | jq -r '"メモリ " + (.memory | tostring)')
$(echo "$result" | jq -r '"実行時間 " + .time + "(sec)"')
EOF
