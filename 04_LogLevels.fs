module LogLevels

let message (logLine: string) : string =
    let startIndex = logLine.IndexOf(':') + 1
    logLine[ startIndex.. ].Trim()

let logLevel (logLine: string) : string =
    let startIndex = logLine.IndexOf('[') + 1
    let endIndex = logLine.IndexOf(']') - 1
    logLine[ startIndex..endIndex ].ToLower()

let reformat (logLine: string) : string =
    $"{message logLine} ({logLevel logLine})"
