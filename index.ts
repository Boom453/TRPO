function calc(a: number, b: number): number {
    console.log(`${a} + ${b} = ${a + b}`);
    return a + b;
}

const calcV2 = (a: number, b: number): number => {
    console.log(`${a} + ${b} = ${a + b}`);
    return a + b;
}

const res1 = calc(10, 4);
console.log(res1);

const res = calcV2(8, 15);
console.log(res);



const users: string[] = ['user'];
const num: number[] = [1, 2, 3,];
const mem: (string | number)[] = [1, 'user'];

const utils = {
    createStringUser : (name: string, age: number, hobby: string[]): string => {
    return name + " " + age + " " + hobby.map();
    },
    createObjectStudents: (name: string, age: number, hobby: string[]): object => {
        return { name, age, hobby: hobby.join(',') };
    }
}


const students: (string | object)[] = [
    utils.createStringUser("Artem1", 21, ["fdfd", "fdfd"]),
    utils.createObjectStudents("Artem2", 21, ["fdfd", "fdfd"]),
    utils.createStringUser("Artem3", 21, ["fdfd", "fdfd"]),
    utils.createObjectStudents("Artem4", 21, ["fdfd", "fdfd"]),

]
console.log(utils.createStringUser("Artem", 21, ["fdfd", "fdfd"]));
console.log(students);

console.log(utils);