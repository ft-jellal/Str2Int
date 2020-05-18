const readlines = require('n-readlines');
const fs = require('fs-extra');

var myArgs = process.argv.slice(2);

if(myArgs.length != 1)
{
    console.log("Input must be 1 text files.\nExample : node index.js c:/text/input.txt")
}

function main()
{
    var resultList = []
    if(fs.existsSync(myArgs[0]))
    {
        
        var liner = new readlines(myArgs[0]);
        var next;
        while (next = liner.next()) {
            var input = next.toString('utf-8');
            var result = 0;
            for(var i = 0; i < input.length; i++)
            {
                if(input[i] <= '9' && input[i] >= '0')
                {
                    var tmp = input[i] - '0'
                    result = result*10+tmp;
                }
            }
            resultList.push(result);
        }
    }
    console.log(resultList);
}

main();