const btn = document.getElementById('btn');
const input = document.getElementById('input');

btn.addEventListener('click', function() {
    const input = document.getElementById('input');
    const vowels = ["a", "e", "i", "o", "u"]

    function countVowel(str) {
        let count = 0;
        for (let letter of str.toLowerCase()) {
            if (vowels.includes(letter)) {
                count++;
            }
        }
        return count;
    }
    let numOfVowel = countVowel(input.value)
    console.log(numOfVowel)
    input.value = '';
});