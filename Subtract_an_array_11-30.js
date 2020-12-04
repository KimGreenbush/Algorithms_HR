function arrayDiff(a, b) {
	if (a.length == 0 || b.length == 0) {
		return a;
	}
	let result = [];
	for (let i = 0; i < a.length; i++) {
		for (let j = 0; j < b.length; j++) {
			console.log(a[i], b[j]);
			if (a[i] == b[j]) {
				break;
			}
			if (j == b.length - 1) {
				result.push(a[i]);
			}
		}
	}
	return result;
}

console.log(arrayDiff([5, -17, 19, -4, -6, -12], [-12, -17, 19, 5, -4, -6]));
