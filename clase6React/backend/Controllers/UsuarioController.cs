using System;
using backend.modelo;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {


        [HttpGet]
        public IActionResult getUsuario()
        {
            // simulamos la bd

            Usuario u = new Usuario();
            u.nombre = "dante";
            u.password = "abc123";
            u.imagenUsuario="data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxISEhUSEhMWFhUVFRUYGRYXGBcYFxUaFRcYFhgVFxUYHSggGholGxgVITEhJSkrLi4uFx8zODMtNygtLisBCgoKDg0OGxAQGy0mHyYrLTAwLSsvLS0tLS4tLSstLS8tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLf/AABEIAKgBKwMBIgACEQEDEQH/xAAbAAABBQEBAAAAAAAAAAAAAAADAAIEBQYBB//EAEoQAAIBAgMEBwQGBwUHBAMAAAECEQADEiExBEFRYQUTIjJxgZEGQlKhI2JykrHBFDNzgqLR8CRDssLhBxVjg7PS05Ojw/EWVHT/xAAaAQACAwEBAAAAAAAAAAAAAAADBAECBQAG/8QAMhEAAgIBAwIDBQgCAwAAAAAAAAECEQMEITESQRMiUQUyYXGBFCORobHR4fBCwRUzUv/aAAwDAQACEQMRAD8A19KkKVeStnpKQqVKlXdTOpCqw9n9lFy8SwkWlRoOhZywU/u4GPiVOoqvqd7O7QE2mJ/Wpg/ety6fwm96im9C148eoW1afhOjX1F2/o+1eEXEBjQ6Mv2WGY8qlUy9bxKVkrI7y5Ecxz8cq9E1ZiJ0ZTbuhLtqWSbqch9IvioyfxXPTs76rFecwZ/0yrcbJtBMo8C4uoGjDc6z7p4bjlzMTpToS3eJYdi58YHe+2ujDTgeBFZ+fQp+aGz9DR0+u6dsitevcymE0REjM0TadnuWmw3VwzowzR9/ZbjHumDkdRnQYLHKsicZxfTLY1IyjNXHgk7M8zUy2KDs9qBFSKC5CGaSb2Ea4a7SqOpgKBX7OJSJIy1G47mHMGCOYouy3saBjkcwwGgZThYDkGBFcJ4kCgqwRpBlHImPdbJQfAiByIHEkbXsrNKE+ifD4+f8mdq+iS8r3RMmlSrleiM8ZfvYRMSSQFX4idB+JJ3AE7qjqCpIUhrrAFnIyQbspyGuFJ4kmZJ5eunEzASVi2gOhd4xMY1AlRxAV+NE/VgKss7SczBY5YncxkNN2WQA0FAl53vwhmPkiq95jgEtCSdTmxzZz5CWPBQOQEZVyLj7+rHkz/OVXwhvLSn2dng4mOJ470RAOoUe6vzMCSYo1Bnn7RDY8HeW7I/6Gu8ufF3I+7igeQpHY13Fx4O4H3Zg+YqRTLt1VEsQBxOWug8eVB65eofoj6AcF1dGDjg0K33lGHywjxoI2gG6gCuGghwVOSEMyksJU9pYBBPebnUm3tSsYAfzt3FH3mUCmbV2WR+BwH7NwgD+PBnuGKj48ztJi+XDGm4kioB7Vxm3L2B5ZuR+9Cn9nUy9iwtgjFBw4tJ3TG6omzFQMEEMozVu99qfek+8JzJ3zSnticlh6Yrl7sjRRTnbOVyaMy0IivLOT7s00qOA0RWoZpwNQpNcsmg4rjCuIadRLbO2BMDTQpO/50YihlaG7JKoueVN608qaqzTwpG4UxSRqiF08KcGO+KZ2udLqzXUjhrMTvrmJhBXvKQy8MSkMJ5SBPKafgG80VUjQVaM+l3EhxUlTNzse0rdtrcXR1DCdRI0I3EaEcRRqznsrtcF7B53E8CfpF+8Q3PrDwrR16XFkWSCku557LjeObi+wDadnDxnhZc1YaqfzB3jfTdm2kk4HGG4BJG5hpjQ7105iYO6ZNB2nZw4EyCDKsO8h0lT8oORBIIIMUQoOv2VdSrqGU6giQfEGs/tfQ7WZNuXt71za4nhvuDl3svenK62baDPV3ID6iO7cA95J+a6rzEMZVCzYIZY1JBIZZQ4Zl7ZBAKkEHQjMHzp1WW39F4iXtQrnVTklzmY7rfWHmDAirV5JBBVh3lPeU8/5iQdxNef1OknhfqvUZhkUh1KhX9oCkDMs0hVES0ZmJIHmSBpxrk3ToigfWuEHzCow+dVxaXNlVwi2RPLCHvMKNfIj8/50rqKwIYAiCDPDfM7qE1q6feRf3Wb54h+FdOxhu+zOD7pgL4FVAxDk01qY9BqXFLZGZJ4VNt7r4A+jdqDSqkuq6XMzoYwMTq488hJgnOcK4ogAAQBkANAOAFA6QeLVwjUW3I8lJrfgnGKTdirpvYBYtM1u06xixG7BkCbqviEgGI6w7t0cwazCkgkvcaC2FWZoziEWSqDOPEmSSSZC2izLaQxM571RIxMJynNVHNgYIBFXuzbOttcKCB+J3kk5kneTmaRTbVGm0k77mfvbIzxi2ZnAzGIWcuYDuCPSgG0VMKXRvguYirRqFxbgN6GBOYOlayhbTs63FKOJB+RGhBGYI1BGYruk7qKCxcxCYIIMEHUEbvzB3gg0C2RixuDiJYIsEsFHwoBJJHaMCcwD3aM7G3jFwz1Uy0d5QMQaBvK6xlIYDSrjovYurXEw+kYAudY4ID8KzA45nUmqqJZsrFt3TpZuRxm2J8mcEeYFA2kYgbThrbOCoDCMyD3WEqxGvZJitPTL1pXUqwDKdQcwat0leozmzXcaK5EFlBI4EiSPWu3rKuIYTGYOYIOkhhmDzFdGzdSzWpJAl1JMkrcZjBO8hsQ8MJOZpXboUSfDLMknQAbzT1qUd+DOacZUiM9q4ujK4Hx9ggbyWUEH0HjTLNzGobCVmcjExMA5HQjMb4OcaU8oz5vkuoTXwLkZE/VGQ4tkQU15L2h9mcqwr5vt9DX06ydP3jI5ptGZaEwrKe3IydQ0cVGFGQ1eMrIqgtciu0qIcUCseXpTsTf0K4LZpdWeFF2NUdDGuFOJFdAbjTwKimSos4tsDnT86WKm51agiVDkZkZbid5GxAcdQVn6yllndM7q3OzX1uIroZVgCPA55jceVYlLBOuVXXs9f6tupPdclkPB+86fvZsOePPMVpaDPT8N9+DK9o406mue5oaVcJjWs3f247QMQP0REqoyxg6M/EEe5pBzBOmwlZj5MigrZa7ftlgyjuCwOiS1xCNGAQFlPlQ+iOl0us9qSXt6ko6Y1+IK4HKYyzB0Iqoa4FhFEmOyixoN/BVHE+GpALf0Vyy3C4R10NtQWUGMSY3kMpgSMI0B1AImSUeWDxZJ5HtHY1tROkNgW6Ae6691xqOIPxKd6nxyIBFYNpvDS7P20Qj0QKfnUi30sw79onnbZSPEhypHgMXjQn0yVMZporb9ogm1dUSRoc0uAe8s67pBzG/IgkQDW+7LLvQmWHNCdfsnyiIN1c2vZ7w6tyRJEBwyHFuwOQAW+ySartpsNaOFzKkwtyIBnRXAyV93A7onCMyeLLpJeJhfl7oJ5cq6Z8nbbhgGUyDoa7UVrZU4k1PeU91uf1W579DuKuXbU0JwN8LwreU5N4qSOdbOl1uPUR259DNzYJY38CRUbpT9Rd/ZXP8BqTUfpMfQ3f2Vz/CabfAKPJZdE/rrvK3aj95rs/4V9KuKotlu4Lyse68ofEkG2SeE4l8bgq9rPjwaUuSD0v0vs+y2+t2m6lpJjE5ABME4RxMA5DhU2ovSPRtjaFCX7Vu6gYMFuIrrIBAOFgRME+tSgNwqxBQ9OKOt8VsBvsi8Z/hZvSrvabwRWdjCorMSSBAUSTJyGQ31n9qIvNcaew6i2pG9VxdseLO8HeAp31ddG7X1iSYDjJwNzDWOR1HIiqp7kvgjeznTSbbs6bRbS4ivJAuLhaPdbgQVgyCRnGoNWdcApt24qgsxCqBJJMADiSdKsQVXTP661+zvf4rNVJbFcY7rfZA+sQGY+hUD97caM20tcv3HMherthFIggBrssQcwWMGNwwggEGm7XZM9Yg7QEEaY11w8JEkgneSMgSarqsWTLpnHHz+vwAwnGOe5DxSNMs3AwDDMH/AOiCDoQZEbop8V5L5msNIoTijGmsKpKJ1gYp1s1wiurQ1yWDCnU0V2aOVKz9EbhSOytVoKVW6mNrVy9EVY2VqcNkarKlXdbOerl6EJNj40dNnAo1KotgpZ5y7jQgFK4mIRnuII1BBkMDxBAI5inUq5Np2gL35JO0bf1mzujRjm3bcDRlu3Ftl1HAgt4GRnEms2p+qYmJW4eyNPpWPcncHJmeOKdQKJtWzhwMyCCCGGoIIYeIlVkHIxQ9p611jDbBDI04mOIoyvGEqMM4YmTE763dP7Qi0nJ0xDNpnJ12JWzWMIzMsc2bTEfDcBuG750RWBmDMGDyPA/L1pli+rglToYIORUwDhYbjBB8CDoRTbCjE5mSWEiIjsrA55QZ58qbu9wiSSpBXmOzE7p0nnFDs3Tctqy5Y1VhImMQBEgETruNFKg5HMHKOM0206soK90jLKMuEbvCoJGbO4uW1LKIdASuohhMcxVp0RcFywLdztMqKl1W7WI4YJM95WzM798EECoFxwz5A20VCY1QNiEkb17B0zHMSVMWZSLlvvLu3Op1Qngdx3GDnmDdOirVjtu2JrPaEta4nNrf2jqyfW1G+RLCJfuaKsFm0BzAG9mHwj55DfV1e6XTCDb7TsJC6YdRNz4IIIjWVIAyMVWzbMEmIljJIEDeYA91RJhd3iSSv/xkMmRTWy7r9gc9U4RruOsWgihBoBHM8zG8nOlfSUYcVI9RFPod29hIAGJjoNMuLHcPnwBrZdJGck29hWoe2s5hlHzFTLHSNxBDL1gHvAgXPAg9ljzlfDea/oueptA6i2gPiFAI9ZpzbMZJRipOZHeQniVOm/ulZnOazU6NZqyz/wB8/wDBu+ZtR5xcJ+RqJtW1vchXKorZYFJJeATBcgSIzKgDTMkSKjxe+K344WP8OL86dZsBTiJLMcixiY4CMgNMh4mTnUuTI6UOsXMQOUQzL6GPwio77RhZmkphIHWKc1UqGBcHIrJbUEDWNSCbL3ro/wCICPA20M/exelKwe3c5FR54QfwYVUklfpN7TrT44UxesR8qjXCCyi45d9RiMkR7wQdlOGIAcN9N/QU3YlHBXuKo8FVgB5UWzZVJwgCczxJ4sdSeZqbZFAnIF5RObW3/gZP+750eom1WFe6gYT9Hd5EHFZggjMHmM6jh7hxIznsMVOEYWYQCCz7iVKnsBYM0R6zHgx3kF8mnlkncQu2wrE2z9IczbGePgT8GkY9OOKABJFRrOFRCrEmTzPEneeZp3XGvM6zV48+TqjGv9/Mfw4pY403ZINNIoPWml1ppTrQajrCuLTS5pYjVOpWWCi2DS6gULGeNECNxqU0+xB0bQK7161GtjlNGX7FSpNlnFD+vXjT1YHSuAV2iJMrR2aU00muYuVTRFCu3QqljoASfKsjte1vebeRuQSYHgNTzq89or0WsM95gPTM/gKqejdrVEIJKuWksJgrlCyMxBnLnyprDCouVWHh93B5FHqYuiNtNtwCThORG4c43RWqmsp0rtKXHUpJhQGYiMZ+KDn5nM1zpPp9URUtZ3cIxHVbe4+L8tBqeB7NicmnFE5o9SU6q+xp7Bi6w+JVYcypKsfTqh5VXdIXSm22wphrtpgucK5t4nKv5aHdJ5g5/wBjr7Ha5Zixe04JOpMq49ArZaCcqtPbZ2tts15e9bd44EnA2EngQhHgTWrg8uJX2EJQ89GlsXQ6hhMMAYOonceY0oWxCAw4XLn8TG5+DihdGbfZuWustsAnaZpMG2SS7B5PZMknhwyisjsvtS6XrrAY7Vy4WCkkFQIVWUkGJVVJUjXgZk8pqPJSMXLg0+2+0a7FfXFbLrdtwxUjEvVscMKcm77bxpvqVsm22HP9ncNbYSoGRtn3rbKc11DKDuxRkorzzprpNtou9YRhAAVVmYAJMk5SSSd3AbpLOhr/AFe0WbnC4oJ+q/YbyAYnyoX2jzdPYL4Hl6u56PY2d+tZbYT6QG5DEr2lwq5xBTqOryjcxmpv6BtHw2v/AFX/APFUbadqWyUvOcK27i4juAuTak8h1gPlWktuGAZSCCAQQZBBzBBGop6GWSVCE8MW7KC9auW46xQASAGRiygnIBpVSCTkMiJymSJj7N+suzrKRxwYBh8sfW+c1Z9N3JKWufWN4J3QeBLww/Zmq+9ZkhlOFgIBiQRwZd48weBEmjNSyQApxx5BuxaMN4uXPKXLKPustSKh7JiFy4GjPA8iczGA5HTJEyz11qUWAiTrkOeU5eQNJyTTpjqaatDqVDa8JwiWaAcK5kAzBO5QYOZgZGq2505bC3iXtp1BYMHYFwVEx1a6zoIY55a1VtItTZOu22DY0CklcJDEqCASVOIAxBLbs8XIU/Z7WEGTLMSzHiTllyAAA5KKzV32wsjZ7d7rkxu1oNaC9u2Cw60lcRPZXHB0Jw8ae/tdY/SBaG0W+qNsk3ijEB5EJIYCMMmeMCo6kW8OXoaelWV2L222W65tOWtjEQtySqOAcjiEMkxPagZwTWjDlSFYyDkHyGfwsBkCdxGR0yMYpIcXHkDtN9VurOZ6toUZs0smQHkMzkN5AoDWmty7kEMSzEf3ZPH4kAAGLURJESVlp+uf9na+bXZ/AVH2cXCCGuviU4WytRIgyOxoQQRyPGapq4YfA++un6dmBjPI8lQrb8wvU8651RpWFVFCgmBOvjMchwAyAgCnG6K8w4wvk0VYzqjS6o8qcb3Kmm8apUPUk6LPOumzzoeM8a5VW4+hG4iKcCOHzptKouiSQDSpUqeC0I1wE8qU12o6SKFNKlUHpbbuqTKMTZAfifKrKN7Isl2Rn+mtrL3CZ7KmAPxPmfyqNQxwP9fzpjXgqkn3fU8B4mtFQqNLsN45Rht/bA7dtRHYU57z8I4D6x+Wu8VXgV2TqdSZPify3DkBSqjfYWnNzdlr7KtG2WeZuD/2rh/KtB7fj6C2eF4ehtXf9Kzvs1bb9JtOFJVHGI7l6wG2snmWGWvkDG76SZAbJuFQBemWgAEWrsGTvmm8SvE18xKf/ajA7J7PbRehhZgbmuQg5ZHtRvkAirW17GXiO1ctqeWJvxC1s+vXs9odruncTwB0miUGkMGKb2Lu7rqHxVl+cmqzpH2a2q2jHCpABOJHBw5d4hsJ9Aa9IFU23baSpYRAhkykEu2Gyx+IAhrhGUDBwmpjBNkP0G+0m0B9he5oGW02eUYnQj8RVR7C+0R2e4LFw/Q3GgTpadjqOCsdRpJxZdomSNruhFtgghWxBmzLQcQRl0gGMxuAEb6znTmxIhDoItXZAU/3bgS9n07S8V0yE0xkcoNSQN6eUY9M18j0u5bvl3c2HksQO1ZyRZCATc35tHFzSFq9/wDr3PvWP/LU32Z23rtksXCwZjaTGQZ7YUBweYYGRxq0rQjldbGTLDFu2ZS65DqxUqVZrbBivZxgMCSpIzZbYGfv1W9O9Lfo2zttJANx4W2Dux5qscgMbDfhI3CLHppAx2q3mS7YVC94sbFthgj3gc53RJgCayn+05ps2CO6bhPmU7PyxUPP2fqH0it9HxMF+mXesN3rH6xiSbgYq5J17SweGQyyFBYyZOZJJJOZJOpJ40qVKmzQlE6Z0qvuhNpDIVyGCBIyBB0J55GqzphQt0xEEBvX/UT51Ce9B5YqgppkOvQ/9nPSpuo+y3DiCKCmeYScJWeCkrHCeQrAWLDuYRGcxMKpYxxgDSth/sw2Njfu3YMLb6vxZ2Vo8QEzH1hV0J50nB2Xe2dazvcxupEjss6BhZGF2IUgRjFwidxHGtBsFgMouKScarqS2QkgSfE1T9MdFXFU7TGK25ZjGqAk4WYb0KwZ3TmIE1Z+zN4NZj4WI8jmPxPpWdqvEtxk3Xp2KeHHwlkTTfGy3XzJ/wCjf1FcOxipNKkvCi+wPqZF/QxxNDbYyN486puiOk7t3am7X0ZLgLuAWYy45fOtJeGRqJaaHFFpqUOSuuW43g+BplTggmCoyGcfjQ7r2F1ZR+9QcmknF0VhljJbEWlTb+1W5hAx5gGB6jOoz7cAYIPqv86G9Ll/8sKk32C4GAzuHsknKB5EZ5Z0xrqgk9aZIjLPTTICKFbTfcBY8jl6GKNbdGyUKI4mD6DWt3wILsH6fgCd0OKOsIaJgDOPEcqebrZQLvZ0yEcM8s6lYCd446fMZ0sDcRx7p/nXeHD0O6CJcuXSythPZnKDnOWcVW7Zst+45Zh4CGyHDStLstue8c/6NMuSDEDxn8orljgt+kHizR8Rxi90Y+9szr3lMcYMesVUdI3JIQaCGP8AlHyJ+7XoV5ssxqM4OnnrWC6dP9pvZR2ly/5acah+VbB8mS1TRBqX0V0e+0XRbTKc2bcijVjx3ADeSN0kRK3HsxsvU7I10R1l0FgeWYtDwzDfvmqQVsA2SdqspYsm1a7K2wrkxJZ8Q6tc8izOASdwjSQQLpDpTrDbNlyuEFmgKSrEYQhxAgMAXkajLjTOknJwKAWL3Lj5RLEMLNocJKkDxWrjZPZiGt9dLhpDKhZVtmMSnEIZhkVmRmVyp/FHylH4UanP8Cns7VJwuFDMQMYGFbhOQS8o3nKHGYJyjRrrZnIPVuZIEqfiXTP6wJAPipymATpb2c2YJkGUuyLHWO2LEwDBVckE4cWUbqHtmx3LQRC2Nlzt3DANxlBlLm4My4pIyPaYARAplxVuivjY5O4WvmHdZBAMEg58OdZ/a7LFrdlEJZmd8A1hALNuZyAwakwJHOtEDUzoPZxhN6Biu7/+GpPVgHhmX8bhqmCNyOyZfDqS5M/sXs3cuYsVxLZRirLhLxkCDixKIKkHfrxkUAez1w2yzgXLTiXVVZXUoYDohnFK4gSDiIKwMhW5VACSBmxk8yABn5ADyp1OOCaoXnq8k+Web+yl27s9y7ZVgSmF0JPYvW7kkTHqGEwWIzAg77YduW6JWQR3lPeUnjy1gjIxWY6etdRea4izks5aLeYiBvP0qz/zjwqEl7aC63EAtsoIBO+Y7LLOa5DL0ggEKQnkx5HF+7+hZ4lkj1R5NvZ2NFd7ir23IxNmSYCrAnQQq5CBlOtZb2j6DS7bOzXOypM2nHukd1R9YZrh95dDrh0PRXSa3hBAVwJZZkfaQ+8vP1iproGBBAIORBzB5EGnXUkKpuD+J41sPsFcF2No7VqDnZZQ5PuyLkYRx10jnVxs3sjsyobD21LuWKXXuMLhzJVQFXCWVQJAOeZ4xtv912ryBreO0JJQo7BWXQE2wQuBtQBBgjME5UR2cpddTbBVWwsUwkMMCmCjEHUhspOokihvGEyamT70S7vRygo8WE6qSCLRAUBSIJFwDCJnPQgGon6LbF437a22d1Cuwss4AUkiArZMS2e8hROlGF8Rgl8E93qLsgTOEPEBd2mQyBGUD2wu8lbYPZy6wLA1zWGJVjOpQ6DwqixP0AeM170vzObHatWTcZHtWjcgsLdsIZWc8LluJ3D1k1adGdHi4JClbTEsSQQ93FmTB7QnezZkaagiTsnRuJA7MLjFQyqZFsGJUsMy2cZmRlIANWezXw6hxIncdQdCp5gyCOINFjBII52Eisd0x0YdjfrrCzZchWtj+7JMDCPhJOQ3ExoRh2VMu21ZSrAFWBBB0IIgg+VRlxRyR6WTjyuDtGSubXABAYyRlDZA6nSmbVtwVSwJyUmIaZgxu/qaZtFhkZrRPcMAxmykSrSd5Bg5ahqjXbCanLnPyk6eVZi0aXJrRx9aUlwVPQRa24YqT2WOWufjr/rV5d268wyhRzzPr/pUNrvuopPOMh5nU0e3YGRMk8z+WlXeni3bDygsjtnCrMO05kmTw9NPlSSyFEZ/h+FB6SuQown3oMHPIExNP2Xag0Ke9gDH5UXvRMccIcIJaTMGBpE7/LlRcFQeir7NikzoR5zl4ZUMbJeGh+fr865bqy10FFi3vYn+vCu9Tb0CYv651LBoNu2wdmLSDEDhFOuUvUjw0OSyoyCgCP6ECihBzHgT/OmjveR/r5U8ipWBuPVRnv2jghqHgns9qfZ/sdW4691z5wfxzrr7W5zIU+Eg+hn8aB144H7rfyri7Sh94fgfQ0NwTVDi0+Lr60txXNtubkjnkfw/kax/Th+nuGZJKyYj+7QaVp7nSCBQ0HMkeEbzyrMdNz17TEkITGndC5eamls8UobFcsUt7IQtliFXIsQo8WOEfMivUdsthbUDJUwGOC22U/gteddCW8W0WR/xUP3Tj/y16ZdthlKnRgQfAiDS8NkAZB6L6OV9sKNJWzs1ogiV7b3bwVgwM4gEffvFa6ypCqC2IgAFiAMRAzaBkJ1qm6EJW6Q5BZ7SZjebRbH4frAQPHhV5Wli9xGfmb6mjlQ+mbc2X4qpdftW+2PIkQeRNN2joew+0WtqdJvWVdbbEtCC5k0LOGSMpiYp/TFyLFyNSuAfaudhf4mFXfG4Jc7FWKsugz/Z7Q+FAh8bf0bfNTVaBS2fbeoxMQTaPabCCzIQM2VRmykASFzkSAZNJaeaUqY9qIOUbXYsOj9iupdvvc2hrq3GU27eFVWwqjugjNiSSSxPCAIzmXLoUqDq5wjmcJaOWSn0qo//ACOwxuKt6wIthkZ7gAZmxZMpiIIE5znpUXpD2ksPahV61mAOAiUU8WfQwfhJPhrTtikccpOkhdMEXbt+2pzW1bT7LnrHHmA1s1RbXtPWp2J91vvLiH5UXoFmkyxLNdYsxzLKtpJJJz77L+FC6MVVx4ZMMykREYWaNY3EHwIpOe8maeCHR5GWHs8cNzZwRmS6jwNt3/yj0rT9IHEBaGtwkGNyDNzxGXZncXWsvZvFXtNhIi7bEmMsbhDofhY1p9lOK5cf4SLYHAAB2MbixYeIVDTGH3RPWKsn0JYFZu/+tvftP8iVpazW0frb37T/AONDTOPky9V7n1G11a5XRRjOLnoU/wBns8RaQHxVQD8wa7Z7F1k3OOsXxELcHL3G5l2ND6BabI+3eHpecD8Kf0p3VC/rC46s8Gg9o/VC48XFcQ1IpU2U7RNpUqVcSZL2xvdXcDgSTbA+65j/ABtVcFxYW5THjUv2nUXb7rMBFtofETcPyuJ92o1pYUDWAB6UJxbkbuki/BjY8+tdU8ooW0XgiljupjbQhTETAYb9cxp413SkMlELucbicX4j86Vu6y5gESMM8BET6CrCwlnEM890ys+GLWjdJWmYKqjeT+X5mk1jlTlZbpXH97DehrJAxHeI8Y0P9camtcf4R6/6UHYZW2A2WGfxkfjReu+q3p/OmscEopFWMwMc4WfMx4aV3A3xD0/1ojMAJNdox23AMzPhH55VIVCdKGo7VWmwgd3hp4f1+VPw8uJM8Z7Y07nnlP8AvwKu5YEyRnUXpBytslcjlEcyK0W12ljMgeJArP7bcUqwRgW5dr/DOdK5opxcojfsn2jKDWnzbrs/9Mz20bYzd6TMkct0DlS6b6MeOvJnIYx8IGcjPQSZ5Gd1W42NCBKNMZwj6kZnu13ZetBebdxgSImNMwZk5CIrPpO1J8npJKLVNmY6Ku4L9puF23PgWAJ9Ca9Sryzb+jblp+qwsC36uMyQchEEywyB8jvFen7PcZlBZcDEZqSDB4SpI9DSqVKhPuD21HKzaIW6vatk5jEu4j4SCVPJjTrftNZuLaZmNpluKXRpCwQyHt5CAxDQYPYzApbRZLQVyZTKndwIPIiR89QKp9s2XExe0O1kblrLFn/eJuM8sjEjMEMzhyUqKPFCcvNsabaPaTZlZQLqOpDSbZ6wqRBUYbYJgjFnxA41n+lOnHv3FwDClsXHVTq7LbZVZwNwdlhZ4E5wFpzeXMEgEag5EeIOY86lbJbibhBiAVyzKIwuO0b1ZktoOMkiRnR5z8peWjx4o9V2+xo795UzYwJiToPE6AczvjjUfCEuKEyxliyjQCCesA3HFAka485MRJSYGKJgTGk745UE4LQ7KAFjkqAAsfDIeZyG80iiGUnS2xm282gChBZkBhkzzZJyZJIkSMMg6HKMtt2KgKwxFQGKNhGI97FADCM8jn86v9pZom4gCqcWJHJdI9+Cg0EzBOUiCCRQrthkAI6uDdtSQmFjiuKsmDBPaOcDwo8Mj2TL/aJxi0gfR1g2rgRoICMwfQQXxPlJOIsySMwAq55wAXVgWCTDNZOKMpjAc/Au33zUj2iuYLWMayU3/wB8DaUGAYHWNbJO6J3VAe+HbG/aOgAU4UA0VRn5nU+AAF1Hz2U01zdvsN2llwsVlmAJGrdoCRnuzit3et4ovWoxYRyFxdQrepIO4k7iQcENs4kLwxAg+hitv7O3cWy2TMxbVZ4m32CfVTTEWuxT2gl5ZImbPfDiR4EHIqRqrDcRWf2n9df/AGi/9G1VxcX6dcGRwk3OBXNUBHHFJB4Iw31UbUPpr/7Rf+jaouPkxNV7n1GUqVKjmcWvQH6thwuP/Ecf+amNeLMXXvPNu1vCqDNy8RwkTwIW3mMVM6DuhVvliAFuYiToF6m3meXZb0qV0ds0FrpXCbhkLn2FOehyVmPaaIzOckSVnya+N+RfIl2bQVQomAIzMk8yd551y/eVFZ3MKqlmPAKJJ9BRKovayXsvaWYAW5cj4FcHB+9hbyVhlIqAkVboz1q/jHWHW4S5HDGcWHwEx5V1id0eZj8qCihdU6uAYmCWII7AgmDnvoY2sYVJGHsksZmTjgBRGsT6ULrXqbEtfgxPw2+PQI4BkOuRzJ3ZVAspjZZ7IYhV+op0idGOXmeVTNuD9WxwgKezm3ahiFzAWJg8ajusiNOB4EaHyNY/tXU10wj9f2G197ibg+Vt9Tu0bBgJQZsBInu3V5g+9xPhuNd2DaCewDulS0kxoQeYP4irK83W2VuAdpRijmMnX/EPSqa+uF+yYzVwdYDnC+XqfOkNHqHp86Tflf8Afy/QzvZ+plNOM+UWuAkZn0yrgZRlIHmKeOiAe/cuP4kAeigU8dFWuB+8a9H9pxfH8B/xfRCfoy2TIlciIGQz34dJpybBGrsRGkwZ4yKko4OhBHKnCkfGyVVgVBKTkuXz9AB2K3wnxLH8TXf0S38C+go1DN1ZwyJ4eNR1ze1shxhy6Grs6DRFHgooorpWgszzASeZIAPhqflVbsulFcBaB1dxsy+HkgB9WYZ+gpt3ryOyLYPEsx+QUUrWzOf1rE8ArED5AfnXENjrNgC9bntELdILQSG+jGXDsl9OdWlUp2U6raRWGYYP2weIJQ89ciCQcjTxtm1FurW1bLROPGwVeBZYJz0GcnwBIummgM307st6hXth+GIGYUz2Z16t1Ia3PKRyFSbF0MoPqDkQRkQRuIMjyolWTaIpMqruxYntdeFuCWCq4S4qtEqwJtqZwi4M/i1zog2YJcAJJRmkEyxxrmqsxMlRmy8+ECZt+0HUrMTEEaggyrDmCAfKhpF1CGEHusB7rCDKndnDKeBU0xDzRoXyXCVhLl5VnEYhSx5Abz8/GDURVckGIdxmTmLSCIQbi5y5TJzCqtR7NwF2F5lVldZmAHFtAVgk6YybkZkYlnWrYGgvy7Bk+rcZZtBd7Gd7MT+OQ8oqJeQpYYH+7DFfs2yWQeShR5VMu3VUSxAGme8nQDieVRdv2hDZfOQ6sgA1ZiCMIB36zMRBmINdFuyZVQ/pQfRsfhKt9xg/5UDBd3uo8EP4lvyom23MWzXH+Ky7eqE09qnVcoppeGRzs7HW43kEH+WrfoG8trZ2GZ6u44jexuMLiqOZN0AczWZv7SRjUmZJ36AZx6RVn0XtQDEYpVerusOIt4ldz9nFZf8A5dGw4pY5K3z/AAxWeqjnTUU/Lzfzar8vzNNsdkqCWguxliNJiAq/VAAA4xOpNU23iL9wcQjeq4f8laGqHpZYvk8bVuP3XuT/AIl9afhyIalfdsjUqVcwsxVE7zmAdcI1ZyOQk8zA30ZujOim3SJPROzl7jMf1S9Xl8dxCx81XEp+0o+Eir+hbPYVFCKICiBv8yd5OpO8mi0u3bNaEemKQPaLwRSx0G4ancFA3kmABvJFRf0ItZuI8Y7yvjI0l1wwDwUQo5KN9OP0l2PctHP61wiQPBVM+LDetTKgseY7b0irYSVeG8SpYgQAg0O7nFCLXDM23kyQAhHmJGWuk1qGt4XuJ8NxvIP9IoHgrgeVPuAbqypdVuv8Rn7HjlK235tzPm6zbOoZSpxoCCI0JbMSTOQ+VCqw6amF4F1/BjVdWL7Qd5E/gbukgoY+ldiy6EfJ0+Fp8nz/ABxVS7SOyn7BvwWPzqQCQZVipiJEaHdBBFCFuAZJJwxJjQDIQN1Kud0/QTxaGWPUyyf4vf8AU1GzKXgCJIkk6AcfnpUv/dzfGPun/uqBsNq6LauFDTbTJWzyE5ggcajf70u/HHKBlyzrayZlje6+pnZdTNzfRLYavRdlSStq2GjXCM/ExXBsZ+C0PDF+UUqVHs1XFD2suQF7MDcGcfxDOnHZsw8dobsRgxzInhu3UqVQpOPAOeOM66ldO/qiUp4j+uVdJpUqqkEQpoZvdrDDE8gYHmcqVKuoizhNxnwJEDvOZODfGGILHKBO+TumwsWQghfEk5kneSd5pUqDke9Gfmm3LcFeskEumpjEugeBEg7nAgTvAAO4r2zeVpA1GqnJh4j1z0O6aVKi4JN7PsTim7oJUa92GD+60K/LPsP6nCeTAnJaVKmcbqSDZFcWLaBhdX3GEbzPYbyYkf8AMJ3U1UNws2JgAxVMJIjDkzEaMcYYQwIhRlmZVKmnFdVinW1GhmxFmdy47Vsi2OB7Icuu8Bg6AjdgjOJIOlNnwnrAO9hVuRkYW84VTxhNy0qVWSS4Bz86afdNfidA/sI//lA9bUU5tjQ94FvtEsPQmKVKldTyh3ScMgXNjcGQAc8gIAETrwGmmdWXR21Fb9ssI7WAkYiCLgIAkqBm4t0qVd40pzjfYpDSQwY59Lb6t3Zo9h7E2T7kFOds90eKwV3mApPeqF08nbtNyuJ5sFcfK21KlWnHky8y8jIMVY9BbPkbx1cQnK3qD+8e14YAcxSpVfI+wtpIq2y2qPtl4qAFguxwoDpJzk/VABY8hlnFKlQh4j9CWgloqJMXb+Z1J665LHmTJ86sKVKuOM902uG8DuuJ5TbMEnmQ6j92q60zljiACzlnmc9eVKlWZqkozfxRo6VuUeeH+P8AbIfTZ7Nscbg+SsfyqBXKVYWt99fL9zYwe6drhFKlSdBjSdFXcNq00wOrSfuiq7b8D3GcLkT+UTSpVpLJJbI8fnW5/9k=";
            return Ok(u);
        }

        [HttpPost]
        public IActionResult saveUsuario([FromBody] Usuario usuario){
            Console.WriteLine(usuario.nombre +  "  " + usuario.password);
            return Ok("guardo bien");
        }
    }
}