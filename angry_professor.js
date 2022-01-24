/// Peer Programmed with Kristen

// k = threshold (must be at least this many on time)
// a = array of student times

// return string yes or no, Question answered is: "Are there enought students to NOT cancel class?"

// quick test cases
// const k2= 2
// const a2 = [0,-1, 2, 1]
// const k = 3
// const a = [-1, -3, 4, 2]

/// Massive test case:
// 500 students
// 89 student threshold
const aTemp =
	"46 -84 39 58 21 -22 21 -4 -93 -95 27 -73 -14 -9 33 36 -87 64 97 94 8 -25 -90 -56 -92 45 23 -61 28 -96 -91 -93 53 -56 79 73 -71 21 -79 -96 33 44 -13 -99 -80 -54 -80 -1 4 -88 12 -75 -11 97 -78 -67 -87 -72 68 -45 -71 72 -47 37 35 88 -39 -35 -64 98 25 -9 -76 17 57 -45 63 84 44 -66 -99 31 -22 46 50 84 -61 -92 -27 85 -25 -17 1 -2 -75 -76 75 -69 -77 -39 -11 -7 17 -61 13 -33 30 -30 -4 -76 -6 58 -64 -83 -95 21 98 31 -31 63 -91 -87 0 52 7 40 -37 46 -29 -94 56 -83 99 73 -6 28 85 -71 -89 94 56 9 -36 46 -41 -90 -12 -55 87 43 -69 -95 42 -92 43 28 -24 45 50 -25 -36 -93 -40 61 -81 77 31 56 -39 57 86 34 28 -22 22 69 -15 60 15 -87 77 98 89 33 55 -15 -29 -4 -80 87 26 65 71 -50 46 -34 -6 87 -38 -27 -16 39 -43 -54 -21 -30 1 -42 73 62 -85 99 -32 90 -59 68 -12 -72 2 83 71 -76 -61 97 66 57 -8 99 -43 -16 11 30 44 84 85 -26 33 81 76 -32 43 -98 -46 -96 -38 95 49 -78 -32 95 -81 25 28 -12 -90 51 -34 -36 98 -73 -97 91 46 -43 83 -47 65 35 -31 -50 -92 6 3 -10 76 -91 -51 72 -3 -79 58 6 -3 -69 41 -8 -25 11 -9 -83 -56 11 -60 -9 -50 5 -19 -84 5 -8 25 31 83 31 15 30 -92 -82 76 -19 32 39 -88 25 -29 -91 50 9 -16 29 -59 -6 -52 56 32 -11 52 19 26 85 77 66 -50 -16 68 1 -57 -78 99 42 -62 -51 56 6 66 -42 19 -27 -84 87 42 31 -51 61 96 86 57 -76 -12 48 77 78 51 65 2 40 96 95 -34 -50 61 45 29 -36 -60 24 -26 34 12 -66 56 62 82 52 67 3 42 50 -73 65 -70 -71 -95 -27 8 -26 55 -21 99 -58 79 -46 -61 44 -83 -20 -2 -54 0 -10 -78 25 77 76 23 94 48 75 -37 96 81 -77 12 34 -65 74 32 -82 50 90 -44 -28 25 -54 75 34 -23 45 96 -1 -27 -9 -78 -73 1 6 49 90 41 89 -51 -78 39 -62 -54 -1 -42 44 -54 1 -34 -5 -45 61 -96 56 -78 22 -9 57 -52 48 68 15 14 -82 28 -83 87 -13 99 -83 -7 -99 94 83 66 -92 27 61 29 -90 -34 83 23 10 69 -4 51 -44"

const a = aTemp
	.replace(/\s+$/g, "")
	.split(" ")
	.map((aTemp) => parseInt(aTemp, 10))

// Kim's approach: sort the array and check the index that matches the threshold to see if it's been met
// NOTE: sort() designed for string comparison so a comparison func must be passed to it for integer comparison
function angryProfessorKim(k, a) {
	a.sort(function (a, b) {
		return a - b
	})

	if (a[k - 1] <= 0) {
		return "NO"
	} else {
		return "YES"
	}
}
//console.log({KIM: angryProfessorKim(89,a)})

// Kristen's approach: Count how many people arrived on time and compare to the threshold
function angryProfessorKristen(k, a) {
	let counter = 0
	for (let element of a) {
		if (element <= 0) {
			counter++
		}
	}
	if (counter < k) {
		return "YES"
	} else {
		return "NO"
	}
}

console.log({ KRISTEN: angryProfessorKristen(89, a) })
