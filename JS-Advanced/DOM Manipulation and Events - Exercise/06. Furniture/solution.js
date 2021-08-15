function solve() {
  const textareas = document.querySelectorAll('textarea');
  const buttons = document.querySelectorAll('button');
  const body = document.querySelector('tbody');


  // create rows in the table for every forniture
  buttons[0].addEventListener('click', function (e) {
    const arr = JSON.parse(textareas[0].value);

    for (const el of arr) {
      const row = document.createElement('tr');

      const cellImage = document.createElement('td');
      const image = document.createElement('img');
      image.setAttribute('src', el.img)
      cellImage.appendChild(image);

      const cellName = document.createElement('td');
      const pName = document.createElement('p');
      pName.textContent = el.name;
      cellName.appendChild(pName);


      const cellPrice = document.createElement('td');
      const pPrice = document.createElement('p')
      pPrice.textContent = el.price;
      cellPrice.appendChild(pPrice);

      const cellDecor = document.createElement('td');
      const pDecor = document.createElement('p')
      pDecor.textContent = el.deFactor;
      cellDecor.appendChild(pDecor);

      const cellCheck = document.createElement('td');
      const input = document.createElement('input');
      input.setAttribute('type', 'chekbox');
      cellCheck.appendChild(input);

      row.appendChild(cellImage);
      row.appendChild(cellName);
      row.appendChild(cellPrice);
      row.appendChild(cellDecor);
      row.appendChild(cellCheck);

      body.appendChild(row);
    }
  })

  // if checked make calculations

  buttons[1].addEventListener('click', function (e) {

  })
}