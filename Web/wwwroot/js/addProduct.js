function postBill() {
    var list_product = JSON.parse(localStorage.getItem('list_product'))
    var listProduct = []
    for (var i = 0; i < list_product.length; i++) {
        var data = {
            "MaSP": Number(list_product[i].MaSP),
            "SoLuong": Number(list_product[i].SoLuong),
            "GiaBan": Number(list_product[i].Gia),
            "GiaGiam": 0,
            "ThanhTien": Number(list_product[i].SoLuong) * Number(list_product[i].Gia)
        }
        listProduct.push(data)
    }

    var data = {
        "MaKH": Number(localStorage.getItem("MaKH")),
        "listProduct": listProduct,
        "TongTien": Number(localStorage.getItem("Total"))
    }
    //    var data = {
    //    "MaKH": 1,
    //    "TongTien": 100123
    //}
    $.ajax({
        type: "POST",
        data: JSON.stringify(data),
        url: "Create",
        contentType: "application/json charset=utf-8",
    }).done(function (res) {
        localStorage.removeItem('list_product')
        localStorage.removeItem('Total')
        localStorage.removeItem('MaKH')
        window.location.href = "/Bill?pageIndex=1";
    });
   
}
function increase(x) {

    var info = x.parentNode.parentNode;
    var count = Number(info.children[2].innerHTML) + 1;
    var _count = Number(info.children[2].innerHTML)
    var price = (Number(info.children[3].innerHTML.split('.')[0]) / Number(_count)) + Number(info.children[3].innerHTML.split('.')[0])
    var id = info.children[0].innerHTML

    info.children[2].innerHTML = count
    info.children[3].innerHTML = price

    var list_product = JSON.parse(localStorage.getItem('list_product'))
    for (var i = 0; i < list_product.length; i++) {
        console.log('id:  ', id)
        console.log('masp: ', list_product[i].MaSP)
        if (list_product[i].MaSP == id.trim()) {
            list_product[i].SoLuong = count
        }

    }
    var json_list_product = JSON.stringify(list_product)
    localStorage.setItem('list_product', json_list_product)
    var _sum = 0
    for (var i = 0; i < list_product.length; i++) {
        _sum += (Number(list_product[i].SoLuong) * Number(list_product[i].Gia))
    }

    localStorage.setItem('Total', _sum)
    document.getElementById("total-bill").innerHTML = 'Tổng tiền: ' + _sum
}
function reduction(x) {
    var info = x.parentNode.parentNode;
    var count = Number(info.children[2].innerHTML) - 1;
    var _count = Number(info.children[2].innerHTML)
    var price = Number(info.children[3].innerHTML.split('.')[0]) - (Number(info.children[3].innerHTML.split('.')[0]) / Number(_count))
    var id = info.children[0].innerHTML

    info.children[2].innerHTML = count
    info.children[3].innerHTML = price

    var list_product = JSON.parse(localStorage.getItem('list_product'))
    for (var i = 0; i < list_product.length; i++) {
        console.log('id:  ', id)
        console.log('masp: ', list_product[i].MaSP)
        if (list_product[i].MaSP == id.trim()) {
            list_product[i].SoLuong = count

        }

    }
    var json_list_product = JSON.stringify(list_product)
    localStorage.setItem('list_product', json_list_product)
    var _sum = 0
    for (var i = 0; i < list_product.length; i++) {
        _sum += (Number(list_product[i].SoLuong) * Number(list_product[i].Gia))
    }

    localStorage.setItem('Total', _sum)
    document.getElementById("total-bill").innerHTML = 'Tổng tiền: ' + _sum
}
function saveMaKH() {
    localStorage.setItem('MaKH', document.getElementById("MaKHInput").value);
}
var list_product = JSON.parse(localStorage.getItem('list_product'))
var bill = document.getElementById("addBill")

if (list_product == null) {
    html = '<h1 class="mt-4">Tạo mới người dùng</h1>\n' +
        '    <ol class="breadcrumb mb-4">\n' +
        '        <li class="breadcrumb-item"><a href="/">Trang chủ</a></li>\n' +
        '        <li class="breadcrumb-item active">Tạo mới người dùng</li>\n' +
        '    </ol>\n' +
        '    <div class="card mb-4">\n' +
        '        <div class="card-header">\n' +
        '            <i class="fas fa-table me-1"></i>\n' +
        '            <a class="btn btn-success" asp-action="Index" asp-controller="Bill">Về danh sách</a>\n' +
        '        </div>\n' +
        '        <div class="card-body">\n' +
        '          <div class="col-md">\n' +
        '              <form asp-action="Create" style="margin-left: 30%">\n' +
        '                  <div asp-validation-summary="ModelOnly" class="text-danger"></div>\n' +
        '                  <div class="form-group" style="font-size: 1.2rem; font-weight:700; padding-bottom:20px; margin-left:0px">\n' +
        '                      <label  asp-for="MaKH" class="control-label">Mã KH</label>\n' +
        '                      <input id = "MaKHInput" name="MaKH" class="form-control" style="width:400px; margin-top:15px"/>\n' +
        '                      <span asp-validation-for="MaKH" class="text-danger"></span>\n' +
        '                  </div>\n' +
        '                  <a class="btn btn-success" style="margin-top:10px; margin-left:330px"href="https://localhost:5001/product?pageIndex=1" onclick="saveMaKH()">Lưu lại</a>\n' +
        '              </form>\n' +
        '    </div>\n' +
        '        </div>'
        + '</div>';
    bill.innerHTML = html
} else {

    var html = '';
    var total = [];
    var mahk = '<div><h1 id="MaKH" style="font-size:1.4rem; padding-top:15px; padding-bottom:15px" >Mã khách hàng:  ' + localStorage.getItem('MaKH') + '</h1></div>'
    html1 = ' <h1 class="mt-4">Tạo mới người dùng</h1>\n' +
        '    <ol class="breadcrumb mb-4">\n' +
        '        <li class="breadcrumb-item"><a href="/">Trang chủ</a></li>\n' +
        '        <li class="breadcrumb-item active">Tạo mới người dùng</li>\n' +
        '    </ol>\n' +
        '    <div class="card mb-4">\n' +
        '        <div class="card-body">\n' +
        '            <div class="card-header">\n' +
        '                <i class="fas fa-table me-1"></i>\n' +
        '                <a class="btn btn-success" asp-action="Create" asp-controller="Bill">Chi tiết hóa đơn</a>\n' +
        '            </div>\n' +
        '            <div class="card-body">\n' + mahk +
        '                <div class="table-responsive">\n' +
        '                    <table class="table table-bordered">\n' +
        '                        <thead>\n' +
        '                            <tr>\n' +
        '                                <th>\n' +
        '                                    Mã SP\n' +
        '                                </th>\n' +
        '                                <th>\n' +
        '                                    Tên SP\n' +
        '                                </th>\n' +
        '                                <th>\n' +
        '                                    Số lượng\n' +
        '                                </th>\n' +
        '                                <th>\n' +
        '                                    Giá\n' +
        '                                </th>\n' +
        '                             \n' +
        '                            </tr>\n' +
        '                        </thead>\n' +
        '                        <tbody>\n' +
        '                         \n' +
        '                        ';
    for (i = 0; i < list_product.length; i++) {
        html += ' <tr>\n' +
            '                            <td>\n' + list_product[i].MaSP +
            '                            </td>\n' +
            '                            <td>\n' + list_product[i].TenSP +
            '                            </td>\n' +
            '                            <td>\n' + list_product[i].SoLuong +
            '                            </td>\n' +
            '                            <td>\n' + list_product[i].Gia + '</td>\n' +
            '                            <td>\n' + '<button id="add" onClick="increase(this)" class="btn btn-success">Thêm</button>' + '</td >\n' +
            '                            <td>\n' + '<button id="increase" onClick="reduction(this)" class="btn btn-success">Giảm</button>' + '</td >\n' +
            '                       </tr>';
        total.push(Number(list_product[i].Gia.split('.')[0]) * list_product[i].SoLuong);
    }
    var _total = total.reduce((a, b) => a + b, 0)
    var total_prix = document.getElementById("total-bill");
    localStorage.setItem('Total', _total)
    total_prix.innerHTML = 'Tổng tiền: ' + _total;


    var page = html1 + html + '  </tbody>\n' +
        '                    </table>\n' +
        '            </div>\n' +
        '        </div>\n' +
        '    </div>\n' +
        '        </div>';
    document.getElementById('post-bill').innerHTML = '<button class="btn btn-danger" id=' + 'postbill' + ' onClick="postBill()" style="margin-left:85%; padding:15px">Tạo hóa đơn</button>'
    bill.innerHTML = page;
}