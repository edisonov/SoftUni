function extractText() {
    const liElement = [...document.getElementsByTagName('li')]
    const elementText = liElement.map(e => e.textContent);

    document.getElementById('result').value = elementText.join('\n');
}