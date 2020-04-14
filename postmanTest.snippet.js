pm.test("Status test", function () {
    console.log(pm)
    pm.response.to.have.status(200);
});
pm.test("Body matches string", function () {
    pm.expect(pm.response.text()).to.include("取得資料");
});
pm.test("Body is correct", function () {
    pm.response.to.have.body('{"message":"取得資料"}');
});
pm.test("Your test name", function () {
    var jsonData = pm.response.json();
    pm.expect(jsonData.message).to.eql("取得資料");
});
pm.test("Content-Type header is present", function () {
    pm.response.to.have.header("Content-Type");
});
pm.test("Successful POST request", function () {
    pm.expect(pm.response.code).to.be.oneOf([200, 201,202]);
});
pm.sendRequest("https://localhost:44314/Home/JsonTest", function (err, response) {
    console.log(response.json());
    pm.expect(response.json().message).to.include("取");
});
