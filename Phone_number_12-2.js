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