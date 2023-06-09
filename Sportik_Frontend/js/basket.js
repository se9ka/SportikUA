
function basketLogic(){
  const btnBasket=document.querySelector('.basket-icon');
  const basket=document.querySelector('.basket');
  const btnClose=document.querySelector('#basket-close');
  
  const btnOrders = document.querySelectorAll('.product__btn');
  
  btnOrders.forEach((btn) =>
      btn.addEventListener('click', addbasket)
  );
  
  btnBasket.addEventListener('click',()=>{
    basket.classList.add('basket-active');
  });
  
  btnClose.addEventListener('click',()=>{
    basket.classList.remove('basket-active');
  });
  
  document.addEventListener('DOMContentLoaded',loadContent);
  
  function loadContent(){
    //Remove films  From basket
    let btnRemove=document.querySelectorAll('.basket-remove');
    btnRemove.forEach((btn)=>{
      btn.addEventListener('click',removeItem);
    });
  
    //Film Item Change Event
    let qtyElements=document.querySelectorAll('.basket-quantity');
    qtyElements.forEach((input)=>{
      input.addEventListener('change',changeQty);
    });
  
  
    updateTotal();
  }
  
  
  //Remove Item
  function removeItem(){
    if(confirm('Are Your Sure to Remove')){
      let title=this.parentElement.querySelector('.basket-film-title').innerHTML;
      itemList=itemList.filter(el=>el.title!=title);
      this.parentElement.remove();
      loadContent();
    }
  }
  
  //Change Quantity
  function changeQty(){
    if(isNaN(this.value) || this.value<1){
      this.value=1;
    }
    loadContent();
  }
  
  let itemList=[];
  
  //Add to basket
  function addbasket(){
   let film=this.parentElement.parentElement.parentElement;
   console.log(film);
   let title=film.querySelector('.product__title').innerHTML;
   let price=film.querySelector('.product__price-value').innerHTML;
   let imgSrc=film.querySelector('.product__img').src;
   
   let newProduct={title,price,imgSrc}
  
   //Check if film already exists in basket
   if(itemList.find((el)=>el.title==newProduct.title)){
    alert("Product Already added in basket");
    return;
   }else{
    itemList.push(newProduct);
   }
  
  
  let newProductElement= createbasketProduct(title,price,imgSrc);
  let element=document.createElement('div');
  element.innerHTML=newProductElement;
  let basketBasket=document.querySelector('.basket-content');
  basketBasket.append(element);
  loadContent();
  }
  
  
  function createbasketProduct(title,price,imgSrc){
  
    return `
    <div class="basket-box">
    <img src="${imgSrc}" class="basket-img">
    <div class="detail-box">
      <div class="basket-film-title">${title}</div>
      <div class="price-box">
        <div class="basket-price">${price} грн за 1 шт.</div>
         <div class="basket-amt">${price}</div>
     </div>
      <input type="number" value="1" class="basket-quantity">
    </div>
    <ion-icon name="close" class="basket-remove"></ion-icon>
  </div>
    `;
  }
  
  function updateTotal()
  {
    const basketItems=document.querySelectorAll('.basket-box');
    const totalValue=document.querySelector('.total-price');
  
    let total=0;
  
    basketItems.forEach(product=>{
      let priceElement=product.querySelector('.basket-price');
      let price=parseFloat(priceElement.innerHTML.replace("грн.",""));
      let qty=product.querySelector('.basket-quantity').value;
      total+=(price*qty);
      product.querySelector('.basket-amt').innerText="грн."+(price*qty);
  
    });
  
    totalValue.innerHTML='грн.'+total;
  
  
    // Add films Count in basket Icon
  
    const basketCount=document.querySelector('.basket-count');
    let count=itemList.length;
    basketCount.innerHTML=count;
  
    if(count<0){
      basketCount.style.display='none';
    }else{
      basketCount.style.display='block';
    }
  
  }
}
