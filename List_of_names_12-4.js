function list(names) {
	let nameList = ""
	if (names.length == 0) {
		return nameList
	}
	if (names.length == 1) {
		return nameList = names[0].name
	}
	if (names.length == 2) {
		return nameList = names[0].name + " & " + names[1].name
	}
	for (let i = 0; i < names.length - 2; i++){
		nameList += names[i].name + ", "
	}
	return nameList += names[names.length-2].name + " & " + names[names.length - 1].name
}

console.log(list([]));