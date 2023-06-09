
async function inputData() {
    let list = document.querySelector('main');
	try {
	  const response = await fetch('http://localhost:8080/api/products');
	  const data = await response.json();
      const uniqueTypesSet = new Set(data.map(obj => obj.typeOfProduct));
      const uniqueTypesArray = Array.from(uniqueTypesSet);
      uniqueTypesArray.forEach(type => {
        const section = createSection(type);
        data.forEach(entry => {
            if (entry.typeOfProduct === type){
                section.append(createCard(entry));
            }
            })
        list.appendChild(section);
      });
  
	} catch (error) {
	  console.error('Error:', error);
	}

  function createSection(key)
  {
    let h = document.createElement("H2");
    h.classList.add("catalog__item-title");
    h.setAttribute("id", key);
    let t;
    switch (key){
        case "protein":
            t = document.createTextNode("Протеїн");
            break;
        case "creatine":
            t = document.createTextNode("Креатин");
            break;
        case "l-carnitine":
            t = document.createTextNode("L-карнітин");
            break;
        default:
            t = document.createTextNode("Default");
            break;
    }
    h.appendChild(t);
    list.appendChild(h);
    let newDiv = document.createElement('div');
        newDiv.classList.add('catalog');
        return newDiv;
  }

  function createCard(obj)
  {
    let newDiv = document.createElement('div');
        newDiv.classList.add('catalog__item');
        newDiv.innerHTML = `
            <div class="product catalog__product">
              <img src="${obj.imgSrc}" alt="" class="product__img">
              <div class="product__content">
                <h3 class="product__title">${obj.title}</h3>
                <p class="product__description">${obj.description}</p>
              </div>
              <footer class="product__footer">
                <div class="product__bottom">
                  <div class="product__price">
                    <span class="product__price-value">${obj.price}</span>
                    <span class="product__currency">грн</span>
                  </div>
                  <button class="btn product__btn" type="button">Order</button>
                </div>
              </footer>
            </div>`;
        return newDiv;
  }
}