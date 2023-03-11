let nombre = "David Vieyra"; 
let altura = 190;

let concatenacion = nombre + " " + altura;

document.write(concatenacion);


function firstNonRepeatedChar(text) {
    // Crear un objeto para contar el número de veces que cada carácter aparece en la cadena
    let charCount = {};
    for (let i = 0; i < text.length; i++) {
      let char = text[i];
      if (charCount[char]) {
        charCount[char]++;
      } else {
        charCount[char] = 1;
      }
    }
  
    // Encontrar el primer carácter que aparece una sola vez
    for (let i = 0; i < text.length; i++) {
      let char = text[i];
      if (charCount[char] === 1) {
        return char;
      }
    }
  
    // Si no se encuentra ningún carácter que aparezca una sola vez, devolver null
    return null;
  }
  
function ordenarAZList() {
  const inputText = document.getElementById("myInput").value;
  const caracteres = inputText.split(""); // Para dividir string en char
  caracteres.sort(); // Para ordenar en orden alfabetico
  const orderText = caracteres.join("");
  document.getElementById("myList").textContent=orderText;
}




// let text = 'abacddbec';
// console.log(firstNonRepeatedChar(text));
// let alphaList = ordenarAZList(document.getElementById("myInput").value);
// document.write(alphaList);
// document.write(add2List(document.getElementById("myInput")));