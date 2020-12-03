function createPhoneNumber(numbers) {
	let digits = "(";
    for (let i = 0; i < numbers.length; i++){
		let digit = numbers[i].toString()
		if (i == "2") {
            digits += digit + ") "
        }
        else if (i == "5") {
            digits += digit + "-"
        }else{
            digits += digit;
		}
    }
    return digits
}

console.log(createPhoneNumber([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]))

// Second one because I missed a day

function spinWords(sentence) {
	let words = sentence.split(" ")
    let backwards = ""
    let finalWord = words.length - 1
	for (let i = 0; i < finalWord; i++) {
		if (words[i].length > 4) {
			let backword = ""
			for (let j = words[i].length - 1; j >= 0; j--) {
				backword += words[i][j]
			}
			backwards += backword + " "
		} else {
			backwards += words[i] + " "
		}
    }
    if (words[finalWord].length > 4) {
		let backword = ""
		for (let j = words[finalWord].length - 1; j >= 0; j--) {
			backword += words[finalWord][j]
		}
		backwards += backword
	} else {
		backwards += words[finalWord]
	}
	return backwards
}

console.log(spinWords("Hey fellow warriors"))