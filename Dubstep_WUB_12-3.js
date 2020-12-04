function songDecoder(song) {
    let letters = song.split("")
    let wubs = ""
    let sentence = ""
    let i = 0
    while (i < letters.length) {
        if (letters[i] === "W" && letters[i + 1] === "U" && letters[i + 2] === "B") {
            wubs += " "
            i+=3
        }
        else {
            wubs.length > 1? sentence += " " : sentence += wubs
            wubs = ""
            sentence += letters[i]
            console.log("sentence",sentence)
            i++
        }
    }
    return sentence.trim()
}

console.log(songDecoder("WUBLATEWUBWUBWUBBWUBWUBWUBCWUB"))

// function songDecoder(song) {
// 	return song.replace(/(WUB)+/g, " ").trim();
// }