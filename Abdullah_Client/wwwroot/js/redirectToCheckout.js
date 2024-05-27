redirectToCheckout = function (sessionId) {
    var stripe = Stripe("pk_test_51PKweVHXPsh7UcDZOmkG79AIMoNmIe3hAFnYva1tYl2m17w2dP52TCFSUI0oacjow5khxw6bF5BGOu4UqV9NH1AJ00wN163iqd");
    stripe.redirectToCheckout({ sessionId: sessionId });
}